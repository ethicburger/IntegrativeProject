using Microsoft.IdentityModel.Tokens;
using System.Numerics;

class Application
{
	private class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string? PhoneNumber { get; set; }

		public User() { }
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
	static void 
	static void AccessApplication()
	{
		while (true)
		{
			Console.Write("> ");
			string access = Console.ReadLine();
			try
			{
				int _access = int.Parse(access);
				if (_access < 0 || _access > 3) { Console.WriteLine("Not a valid option, choose from one of the options provided"); }
				else
				{
					switch (_access) {
						case 0:
							Console.WriteLine("Login");
							break;
						case 1: 
							Console.WriteLine("Register");
							break;
						case 2:
							Console.WriteLine("Exit");
							break;
					}
				}

				if (_access == 2) { break; }
			}
			catch (ArgumentException e) {
				Console.WriteLine("Not a valid Input, choose from the options provided");
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
