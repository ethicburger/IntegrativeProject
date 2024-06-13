namespace User_Controller;

using UserRepository;
using UserNamespace;
public class UserController
{
	UserRepository userRepository;
	List<User> users;
	public UserController() {
		if (userRepository == null) { 
			userRepository = new UserRepository();
		}
	}

	public List<User> getAllUser() {
		string[] content = userRepository.getContent();
		foreach (string line in content)
		{
            //Beware the position 0 from each line is the _id
			string username = line.Split(',')[1];
			string email = line.Split(",")[2];
			string password = line.Split(',')[3];

			User current_user = new User()
			{
				Username = username,
				Email = email,
				Password = password
			};

			users.Add(current_user);
		}
		return this.users;
	}

	public void AddUser(User user) { }
}