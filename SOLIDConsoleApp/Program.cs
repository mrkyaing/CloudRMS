using SOLIDPrinciple.S;
using SOLIDPrinciple.O;
using SOLIDPrinciple.L;

Console.WriteLine("Hello, World!");
IUserRepository userRepository = new UserRepository();
userRepository.save();
IEmailService emailService= new EmailService();
emailService.SendEmail("akog02@gmail.com");
Rectangle rectangle = new Rectangle(){
    Height = 200,
    Width = 200,
};
Circle circle = new Circle(){
    Radius = 10,
};
Square square = new Square()
{
    side = 3
};
AreaCalculator areaCalculator = new AreaCalculator();
Console.WriteLine(areaCalculator.GetArea(rectangle));
Console.WriteLine(areaCalculator.GetArea(circle)); 
Console.WriteLine(areaCalculator.GetArea(square));
Car bmw=new BMW();
Console.WriteLine(bmw.GetColor());
Car toyata = new Toyota();
Console.WriteLine(toyata.GetColor());
Apple apple = new Orange();
Console.WriteLine(apple.GetColor());
public class Apple
{
    public virtual string GetColor()
    {
        return "Red";
    }
}
public class Orange : Apple
{
    public override string GetColor()
    {
        return "Orange";
    }
}