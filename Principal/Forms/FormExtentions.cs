using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Forms
{
    public static class FormExtentions
    {
        public static void ExibirFormEspera(this XtraForm form)
        {
            SplashScreenManager.ShowDefaultWaitForm(form, true, true, "Processando", "Aguarde");
        }

        public static void FecharFormEspera(this XtraForm form)
        {
            if (SplashScreenManager.Default == null)
                return;
            if (SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.CloseDefaultWaitForm();
        }

    }
}
