Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.IO

Module utilerias

    Public varGlobal_IdUsuario As String
    Public varGlobal_NombreUsuario As String
    Public varGlobal_IdEmpresa As String
    Public varGlobal_Empresa As String
    Public varGlobal_rfcEmpresa As String
    Public Function validaRfc(rfc As String)
        If (Regex.IsMatch(rfc.Trim, "^([A-ZÑ\x26]{3,4}([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1]))([A-Z\d]{3})?$")) Then
            Return ""
        Else
            Return MsgBox("No ha ingresado un RFC válido o está incompleto", MsgBoxStyle.Information)
        End If
    End Function
    Public Function esFisicaOMoral(rfc As String)
        If rfc.Length = 12 Or rfc = "XEXX010101000" Then
            Return "M"
        ElseIf rfc.Length = 13 Then
            Return "F"
        Else
            Return MsgBox("No ha ingresado un RFC válido o está incompleto", MsgBoxStyle.Information)
        End If
    End Function
    Public Function validaMail(mail As String)
        If (Regex.IsMatch(mail.Trim, "^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")) Then
            Return ""
        Else
            Return MsgBox("No ha ingresado un mail válido", MsgBoxStyle.Information)
        End If
    End Function

    Public Function deshabilitar(form As Object)
        Dim name As frmEmpresas
        name = New frmEmpresas

        Dim f As Integer
        For f = 0 To form.Controls.Count - 1
            If TypeOf form.Controls(f) Is TextBox Or TypeOf form.Controls(f) Is CheckBox Or TypeOf form.Controls(f) Is DateTimePicker Or TypeOf form.Controls(f) Is ComboBox Then
                form.Controls(f).Enabled = False
            End If
        Next
        'form.BindingNavigatorAddNewItem.Enabled = False
        'form.CXP_ProveedoresBindingNavigatorSaveItem.Enabled = True
    End Function

    Function Genera_Pass(Longitud As Byte, Optional MiCadena As String = "", Optional Codigo_ansii As Boolean = False,
Optional Numeros As Boolean = False, Optional Minusculas As Boolean = False, Optional Mayusculas As _
Boolean = False, Optional Especiales As Boolean = False, Optional bRepetir As Boolean = True)
        'Longitud = Parametro para SAber de cuantos caracteres se hara el pass
        'MiCadena = PArametro para trabajar con los caracteres seleccionados por el usuario
        'Codigo_ansi = Parametro para trabajar con todos los caracteres
        'Numeros,Minusculas,Mayusculas,Especiales = PArametros para armar la cadena con lo que seleccione el usuario
        Const sNum = "1234567890"
        Const sMin = "abcdefghijklmnopqrstuvwxyz"
        Const sMay = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Const sEsp = "[]{}!¡¿?#$%&/()"
        Dim sIn As String = "" 'Variable para armar la contraseña
        Dim sFi As String 'Variable para armar la cadena sobre la que se va a sacar la contraseña
        Dim i As Integer 'Variable para los bucles
        Dim iRan As Integer 'Variable para saber la posicion de donde vamos a sacar el caracter
        Dim iCadFin As Integer 'Variable para saber la longitud de la cadena armada
        Try

            sFi = "" 'Iniciamos la variable por si las dudas
            If MiCadena = "" Then 'Si esta es diferente entonces ya no arma nada
                If Codigo_ansii = True Then 'Si se escoge el codigo ansi como verdadero entonces ya no checa nada mas
                    For i = 33 To 126 'Bucle para armar la cadena con los caracteres ascii del 33 al 126
                        sFi = sFi & Chr(i)
                    Next
                Else
                    'Las siguientes condiciones son para armar la cadena segun las opciones seleccionadas
                    If Numeros = True Then sFi = sFi & sNum
                    If Minusculas = True Then sFi = sFi & sMin
                    If Mayusculas = True Then sFi = sFi & sMay
                    If Especiales = True Then sFi = sFi & sEsp
                End If
            Else
                sFi = MiCadena
            End If


            iCadFin = Len(sFi) 'Aqui se sabe la logitud de la cadena final
            If bRepetir = False Then
                If Longitud > iCadFin Then Longitud = iCadFin
            End If
            If iCadFin = 0 Or Longitud < 1 Then 'Si la cadena final es "" lo longitud es menor de 1 entonces Pone mi Alias JeJe ;-)
                Genera_Pass = "ZiTrO" : Exit Function
            End If
            For i = 1 To Longitud 'Bucle para hacer el pass con la longitud seleccionada
                Randomize() 'Empieza la funcion de numeros aleatorios
                Do
                    iRan = Math.Round(Rnd(iCadFin) * iCadFin, 0) 'Aqui generamos la posicion aleatoria de un numero valido dentro de la cadena de caracteres
                Loop While iRan = 0 'Si el azar nos da 0 lo volvemos a hacer, por que en el mid nos daria error el 0
                sIn = sIn & Mid(sFi, iRan, 1) 'Aqui ya obtenemos el caracter y lo concatenamos con el anterior
                If bRepetir = False Then
                    sFi = Replace(sFi, Mid(sFi, iRan, 1), "")
                    iCadFin = iCadFin - 1
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(Err.Number & " " & Err.Description, "Error a Tratar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sIn = ""
        End Try
        Return sIn
    End Function

    Function getMd5Hash(ByVal input As String) As String
        Dim md5Hasher As MD5 = MD5.Create()
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function
End Module
