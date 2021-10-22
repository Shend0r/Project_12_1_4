// See https://aka.ms/new-console-template for more information

using Project_12_1_4;

Console.WriteLine("Введите ваш логин");

User user = new User();

user.Login = Console.ReadLine();

Console.WriteLine("Добро пожаловать! {0}", user.Name());

if (user.IsPremium() == true)
{

}
else
{
	Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
	Thread.Sleep(1000);

	Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
	Thread.Sleep(2000);

	Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
	Thread.Sleep(3000);
}

Console.ReadKey();

