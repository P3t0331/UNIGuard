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

        public static void CheckCheckBox(Form form, CheckBox ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(new MethodInvoker(delegate { ctrl.Checked = true; }));
            }
            else
            {
                ctrl.Checked = true;
            }

        }

        public static void UncheckCheckBox(Form form, CheckBox ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(new MethodInvoker(delegate { ctrl.Checked = false; }));
            }
            else
            {
                ctrl.Checked = false;
            }

        }
    }
}
