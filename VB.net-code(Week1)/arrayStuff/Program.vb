Imports System

Module Program
    Sub Main(args As String())
     
     
    dim firstNum As integer = 0
    dim secondNum As integer = 0
    dim thirdNum As integer = 0
    dim fourthNum As integer = 0
    dim fifthNum As integer = 0
    dim sixthNum As integer = 0
    dim seventhNum As integer = 0
    
     Console.WriteLine("enter postive integers you would like to store. Enter 0 when complete.")
       
       
       Dim intData() As Integer = {firstNum, secondNum, thirdNum, fourthNum, fifthNum, sixthNum, seventhNum}
       firstNum = Convert.ToInt32(Console.ReadLine())
       if (firstNum > 0) then
           secondNum = Convert.ToInt32(Console.ReadLine())
       End If
       if (secondNum > 0) then
            thirdNum = Convert.ToInt32(Console.ReadLine())
       End If 
       if (thirdNum > 0) then
            fourthNum = Convert.ToInt32(Console.ReadLine())
       End If
       if (fourthNum > 0) then
            fifthNum = Convert.ToInt32(Console.ReadLine())
       End If
       if (fifthNum > 0) then
       sixthNum = Convert.ToInt32(Console.ReadLine())
       End If
       if (sixthNum > 0) then
       seventhNum = Convert.ToInt32(Console.ReadLine())
       End If
       Console.WriteLine(firstNum &", "& secondNum &", "& thirdNum &", "& fourthNum &", "& fifthNum &", "& sixthNum &", "& seventhNum) 
       Console.WriteLine("Thank you!") 

    end sub 
End Module
