using System;

/// <summary>
/// Page that displays user's contact information and allows them to either
///     Confirm that the details are correct
///     Go back to the previous page and modify the details
/// </summary>
/// <author>
/// Kathryn Browning
/// </author>
/// <version>
/// February 10, 2015
/// </version>
public partial class Confirm : System.Web.UI.Page
{
    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        
        this.DisplayReservation();
    }

    /// <summary>
    /// Displays the reservation.
    /// </summary>
    private void DisplayReservation()
    {
        var existingDetails = (ContactDetails)Session["ContactDetails"];

        this.lblFirstName.Text = existingDetails.FirstName;
        this.lblLastName.Text = existingDetails.LastName;
        this.lblEmail.Text = existingDetails.Email;
        this.lblPhone.Text = existingDetails.Phone;
        this.lblPreferredMethod.Text = existingDetails.PreferredMethod;
    }

    /// <summary>
    /// Handles the Click event of the btnConfirm control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void btnConfirm_Click(object sender, EventArgs e)
    {        
        var count = Convert.ToInt32(Session["Count"]);
        this.lblMessage.Text = "It took you " + count + " clicks on Submit<br />" +
            "Thank you for your request.<br />" +
            "We will get back to you within 24 hours.";
    }
}