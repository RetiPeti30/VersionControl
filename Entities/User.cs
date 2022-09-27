using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Harmadikhet_DFP98U.Entities
{ 
public class User	
{
    public Guid ID { get; set; } = Guid.NewGuid();
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Fullname
    {
        get
        {
            return string.Format(
                "{0} {1}",
                Lastname,
                Firstname);
        }
    }
}
}
