namespace UserRepository;

public class UserRepository
{
	private string _path = "./User.txt";
	private string[]? _file;
	public UserRepository()
	{
		if (!File.Exists(path: this._path)) {
			File.Create(_path);
		}
	}

	public string[] getContent()
	{	
		this._file = File.ReadAllLines(_path);
		return _file;
	}
}
