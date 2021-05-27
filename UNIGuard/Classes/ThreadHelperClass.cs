using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIGuard.Classes
{
    public static class ThreadHelperClass
    {
        delegate void SetTextCallback(Form f, Control ctrl, string text);

        public static void SetText(Form form, Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            else
            {
                ctrl.Text = text;
            }
        }
        
        public static string GetText(Form form, Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                string result = "";
                ctrl.Invoke(new MethodInvoker(delegate { result = ctrl.Text; }));
                return result;
            } 
            else
            {
                return ctrl.Text;
            }
        }

        public static void DisableElement(Form form, Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(new MethodInvoker(delegate { ctrl.Enabled = false; }));
            }
            else
            {
                ctrl.Enabled = false;
            }

        }

        public static void EnableElement(Form form, Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(new MethodInvoker(delegate { ctrl.Enabled = true; }));
            }
            else
            {
                ctrl.Enabled = true;
            }

        }
    }
}
