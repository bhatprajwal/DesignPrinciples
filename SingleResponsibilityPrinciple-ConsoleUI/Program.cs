using SRP.Models;
using SRP.Service;

Console.WriteLine("Welcome");

User user = new User()
{
    FirstName = "Prajwal",
    LastName = "Bhat",
    Email = "pb@email.com",
};

bool isUserInputValidated = ValidateUser.IsBasicValidationChecked(user);
bool isValidEmail = ValidateUser.IsValidEmail(user.Email);
if(isUserInputValidated && isValidEmail)
{
    UserDao.Add(user);
    Console.WriteLine("User \"" + user.FirstName + " " + user.LastName + "\" added successfully");
    Email email = new Email()
    {
        // Each individual Property will set here
    };
    //email.Send();

    Console.WriteLine("Users List\n");
    var users = UserDao.GetAll();
    foreach (var value in users)
    {
        Console.WriteLine("Id - {0}\nFirst Name - {1}\nLast Name - {2}\nEmail - {3}\n\n", value.Id, value.FirstName, value.LastName, value.Email);
    }
}
else
{
    Console.WriteLine("Please provide the valid input");
}

Console.ReadLine();