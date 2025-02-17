'ChristopherZ
'Spring 2025
'RCET2265
'Convert And Validate
'https://github.com/Christopher-isu/ConvertAndValidate.git

Option Explicit On 'forces all variables to be declared
Option Strict On   'forces all variables to be declared of the correct data type

Module ConvertAndValidate

    Sub Main()

        ' For testing the function, add this to your Sub Main()
        Dim aValidNumber As Integer

        Do
            Console.WriteLine("Enter a number (or 'q' to quit):") 'prompt the user to enter a number
            Dim userResponse As String = Console.ReadLine()

            If userResponse.ToLower() = "q" Then 'if the user enters 'q', exit the loop
                Exit Do
            End If

            If ConversionValid(userResponse, aValidNumber) = True Then 'if the conversion is successful, print the result
                Console.WriteLine($"{userResponse} converted successfully to {aValidNumber}!")
            Else
                Console.WriteLine($"Oops, {userResponse} does not seem to be a number") '   
            End If

        Loop

    End Sub

    Function ConversionValid(inputString As String, ByRef toInteger As Integer) As Boolean 'ByRef is a reference to the variable

        Dim status As Boolean = False 'status is a flag to determine if the conversion was successful

        Try
            toInteger = Convert.ToInt32(inputString) 'try to convert the inputString to an integer
            status = True
        Catch ex As Exception 'if the conversion fails, the exception is caught here
            status = False
        End Try

        Return status 'return the status of the conversion

    End Function


End Module
