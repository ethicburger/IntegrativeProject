using Microsoft.IdentityModel.Tokens;
using User_Controller;
class Application
{
	private class User
	{
		public string? Username { get; set; }
		public string? Email { get; set; }
		public string? Password { get; set; }

		public User() { }
		public User(string Username, string Password) { }
	}
	private class Session
	{
		public string Value { get; set; }
		public Session()
		{
			this.Value = UniqueId.CreateRandomId();
		}
	}
	static void Menu()
	{
		Console.WriteLine("1: Login");
		Console.WriteLine("2: Register");
		Console.WriteLine("3: Exit Application");
	}
	static void LoginApplication() {
		UserController user_controller = new UserController();

		Console.Write("Username: ");
		string username = Console.ReadLine();

		Console.Write("Email: ");
		string email = Console.ReadLine();

		Console.Write("Password: ");
		string password = Console.ReadLine();

		User user = new User()
		{
			Username = username,
			Email = email,
			Password = password
		};
	}
	static void RegisterApplication() {
		UserController user_controller = new UserController();
	}
	static void AccessApplication()
	{
		int _attempts = 3;
		while (true)
		{
			Console.Write("> ");
			string? access = Console.ReadLine();
			try
			{
				int? _access = int.Parse(access);
				switch (_access) {
					case 1:
						Console.WriteLine("Login");
						LoginApplication();
						break;
					case 2:
						Console.WriteLine("Register");
						RegisterApplication();
						break;
					case 3:
						Console.WriteLine("Exit");
						break;
					default:
						_attempts--;
						Console.WriteLine("Not a valid option, choose from one of the options provided");
						break;
				}

				if (_access == 3) { break; }

				if (_attempts <= 0) { break; }
			}
			catch (Exception e) {
				Console.WriteLine("Not a valid Input, choose from the options provided");
				_attempts--;
			}
		}
		
	}
	static void Main(string[] args)
	{
		Console.WriteLine("Welcome to the Integrative Project");
		Session session = new Session();
		Menu();
		AccessApplication();
	}
}
