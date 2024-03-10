
//void Calculator()
//{
//    bool isCorrectCalculate = true;
//    try
//    {

//        int a = 5;
//        int b = 0;
//        //var result = a / b;
//        //Console.WriteLine(result);


//        int[] arr = { 1, 2, 3 };
//        //arr[5] = 100;

//    }
//    //catch (DivideByZeroException ex)
//    //{

//    //    Console.WriteLine(ex.Message);
//    //}
//    //catch (IndexOutOfRangeException ex)
//    //{

//    //    Console.WriteLine(ex.Message);
//    //}
//    catch (Exception ex)
//    {
//        isCorrectCalculate = false;

//    }
//    finally
//    {
//        SendMessage(isCorrectCalculate);
//    }


//}




////Calculator();

//void SendMessage(bool isCorrectCalculate)
//{
//    if (isCorrectCalculate)
//    {
//        Console.WriteLine("Your message sent successfull");
//    }
//    else
//    {
//        Console.WriteLine("Your message failed");
//    }
//}


using ExceptionPractice.Helpers.Exceptions;

string GetById(int? id)
{
    try
    {
        if (id == null)
        {
            //throw new ArgumentNullException();
            throw new CustomArgumentNullException("Argument cannot be null");
        }
        return "Kamran bey";
    }
    catch (Exception ex)
    {

        return ex.Message;
    }
}

var result = GetById(null);
Console.WriteLine(result);


