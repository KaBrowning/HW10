using System.Diagnostics;

/// <summary>
/// Class to keep track of a person's contact details
/// </summary>
/// <author>
/// Kathryn Browning
/// </author>
/// <version>
/// February 10, 2015
/// </version>
public class ContactDetails
{
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _phone;
    private string _preferredContact;

    /// <summary>
    /// Gets or sets the first name.
    /// </summary>
    /// <value>
    /// The first name.
    /// </value>
    public string FirstName
    {
        get { return this._firstName; }
        set
        {
            Trace.Assert(value != null, "Invalid first name");
            this._firstName = value;
        }
    }

    /// <summary>
    /// Gets or sets the last name.
    /// </summary>
    /// <value>
    /// The last name.
    /// </value>
    public string LastName
    {
        get { return this._lastName; }
        set
        {
            Trace.Assert(value != null, "Invalid last name");
            this._lastName = value;
        }
    }

    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    /// <value>
    /// The email address.
    /// </value>
    public string Email
    {
        get { return this._email; }
        set
        {
            Trace.Assert(value != null, "Invalid email");
            this._email = value;
        }
    }

    /// <summary>
    /// Gets or sets the phone number.
    /// </summary>
    /// <value>
    /// The phone number.
    /// </value>
    public string Phone
    {
        get { return this._phone; }
        set
        {
            Trace.Assert(value != null, "Invalid phone number");
            this._phone = value;
        }
    }

    /// <summary>
    /// Gets or sets the preferred contact method.
    /// </summary>
    /// <value>
    /// The preferred contact method.
    /// </value>
    public string PreferredMethod
    {
        get { return this._preferredContact; }
        set
        {
            Trace.Assert(value != null, "Invalid contact method");
            this._preferredContact = value;
        }
    }
}