using System;

/// <summary>
/// Page that allows the user to enter their contact details
/// </summary>
/// <author>
/// Kathryn Browning
/// </author>
/// <version>
/// February 10, 2015
/// </version>
public partial class Request : System.Web.UI.Page
{
    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;

        if (Session["ContactDetails"] != null)
        {
            this.DisplayReservation();
        }
    }

    /// <summary>
    /// Displays the reservation.
    /// </summary>
    private void DisplayReservation()
    {
        var existingDetails = (ContactDetails)Session["ContactDetails"];

        this.txtFirstName.Text = existingDetails.FirstName;
        this.txtLastName.Text = existingDetails.LastName;
        this.txtEmail.Text = existingDetails.Email;
        this.txtPhone.Text = existingDetails.Phone;
        this.ddlPreferredMethod.SelectedValue = existingDetails.PreferredMethod;
    }

    /// <summary>
    /// Handles the Click event of the btnSubmit control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!Page.IsValid)
            return;

        var newDetails = new ContactDetails()
        {
            FirstName = this.txtFirstName.Text,
            LastName = this.txtLastName.Text,
            Email = this.txtEmail.Text,
            Phone = this.txtPhone.Text,
            PreferredMethod = this.ddlPreferredMethod.SelectedValue
        };

        var count = Convert.ToInt32(Session["Count"]);
        count++;
        Session["Count"] = count;

        Session["ContactDetails"] = newDetails;
        Response.Redirect("Confirm.aspx");
    }

    /// <summary>
    /// Handles the Click event of the btnClear control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void btnClear_Click(object sender, EventArgs e)
    {
        this.txtFirstName.Text = "";
        this.txtLastName.Text = "";
        this.txtEmail.Text = "";
        this.txtPhone.Text = "";
        this.ddlPreferredMethod.SelectedIndex = 0;
        this.lblMessage.Text = "";
    }
}