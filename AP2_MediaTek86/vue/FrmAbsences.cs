using AP2_MediaTek86.connexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2_MediaTek86.vue
{
    public partial class FrmAbsences : Form
    {
        public FrmAbsences()
        {
            InitializeComponent();
            ConnexionBDD bdd = ConnexionBDD.getInstance("server=localhost;user id=responsable;password=motdepasse;persistsecurityinfo=True;database=mediatek86");
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            bdd.ReqSelect("SELECT * from personnel order by nom, prenom;", parameters);
            bdd.Read();
            MessageBox.Show(bdd.Field("nom").ToString());
            bdd.close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void zoneAjout_Enter(object sender, EventArgs e)
        {

        }
    }
}
