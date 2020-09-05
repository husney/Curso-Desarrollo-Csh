using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            String n = "a";

            try
            {
                int n1 = Convert.ToInt32(n);
            } catch (Exception ex)
            {
                Console.WriteLine("Error");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Esto siempre se ejecuta");
            }

            try
            {
                //Haga...
            }catch(ExecutionEngineException ex)
            {
                //En caso de error Haga...
            }
            catch(EntryPointNotFoundException exPoint)
            {

            }
            finally
            {
                //Siempre haga...
            }

        }

        
    }
}
