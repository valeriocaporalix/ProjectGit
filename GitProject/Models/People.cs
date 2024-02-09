namespace GitProject.Models;

public class People
{
    private string? _name;
    private string? _lastName;

    public string? Name
    {
        get => _name;
        init
        {
            _name = value;
            UpdateEmail();
        }
    }

    public string? LastName
    {
        get => _lastName;
        init
        {
            _lastName = value;
            UpdateEmail();
        }
    }

    public string? Email { get; private set; }

    private void UpdateEmail()
    {
        if (Name == null || LastName == null)
            return;

        Email = $"{Name}.{LastName}@example.com".ToLower();
    }
}