
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe
{
    [System.Drawing.ToolboxBitmap("RequiredTextBox_Tool.bmp")]
    [ProvideProperty("MissingBackColor", "System.Windows.Forms.TextBox")]
    [ProvideProperty("MissingBackColor", "System.Windows.Forms.ComboBox")]
    public partial class RequiredFieldsChecker : Component, IExtenderProvider
    {
        public RequiredFieldsChecker()
        {

        }

        public RequiredFieldsChecker(IContainer container)
        {
            container.Add(this);


        }

        #region IExtenderProvider Members

        // We can only extend TextBoxes.
        public bool CanExtend(object extendee)
        {
            return (extendee is TextBox || extendee is ComboBox);
        }

        // The list of our clients and their colors.
        private List<Control> Clients =
            new List<Control>();
        private Dictionary<Control, Color> MissingColors =
            new Dictionary<Control, Color>();
        private Dictionary<Control, Color> PresentColors =
            new Dictionary<Control, Color>();

        // Implement the MissingBackColor extension property.
        // Return this client's MissingBackColor value.
        [Category("Appearance")]
        [DefaultValue(null)]
        public Color? GetMissingBackColor(Control client)
        {
            // Return the control's MissingBackColor if it exists.
            if (MissingColors.ContainsKey(client))
                return MissingColors[client];
            return null;
        }

        // Set this control's MissingBackColor.
        [Category("Appearance")]
        [DefaultValue(null)]
        public void SetMissingBackColor(Control client,
            Color? missing_back_color)
        {
            if (missing_back_color.HasValue)
            {
                // Save the client's colors.
                MissingColors[client] = missing_back_color.Value;
                PresentColors[client] = client.BackColor;

                // If the control isn't already
                // in our client list, add it.
                if (!Clients.Contains(client))
                {
                    Clients.Add(client);
                    client.Validating += Client_Validating;
                }
            }
            else
            {
                // If the client is in our client list, remove it.
                if (Clients.Contains(client))
                {
                    Clients.Remove(client);
                    MissingColors.Remove(client);
                    PresentColors.Remove(client);
                    client.Validating -= Client_Validating;
                }
            }
        }

        // Display the appropriate BackColor.
        private void Client_Validating(object sender, CancelEventArgs e)
        {
            ValidateClient(sender as Control);
        }
        private void ValidateClient(Control client)
        {
            client.BackColor = CorrectColor(client);
        }

        // Return the correct color for a TextBox.
        private Color CorrectColor(Control client)
        {
            if (client.Text.Length < 1)
                return MissingColors[client];
            else
                return PresentColors[client];
        }

        #endregion

        // Return the first required field that is blank.
        public Control FirstMissingField()
        {
            // Check all of the fields.
            CheckAllFields();

            // See if any clients are blank.
            foreach (System.Windows.Forms.Control client in Clients)
                if (client is TextBox)
                {
                    TextBox cm = (TextBox)client;
                    if (cm.Text.Length == 0) return client;
                }
                else if (client is ComboBox)
                {
                    ComboBox cm = (ComboBox)client;
                    if (cm.SelectedItem == null) return client;
                }
              

            return null;
        }

        // Check all clients now. This is useful
        // for initializing background colors.
        public void CheckAllFields()
        {
            foreach (Control client in Clients)
                ValidateClient(client);
        }
    }
}
