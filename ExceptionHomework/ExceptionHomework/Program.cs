
//1.Ededin faktorilalini tapan method yazmaq. Eger menfi eded daxil edilibse custom exception cixarsin.

//using ExceptionHomework.Controllers;

//MathFactorialController mathFactorialController = new MathFactorialController();
//mathFactorialController.GetFactorial();

//2.Login ucun custom exception yazib isdifade etmek. Eger email ve yaxud password sehvdirse
//custom exception istifade edin. Models, Services, Controller folderleriniz olacaq. 
//Service mentiqi ile yazirsiz. 

using ExceptionHomework.Controllers;

UserController userController = new UserController();
userController.GetAll();
//userController.CheckEmailOrPassword();

//3.Bir custom exception classi yaradin. Login olan zaman passwordun simvollarinin
//  sayi 6-dan kicikdirse exception cixarsin

userController.Login();