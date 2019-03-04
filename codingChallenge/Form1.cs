using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*summary- taking a phrase or word and replacing the 
value with user input and then displaying new phrase or word
*/

namespace codingChallenge
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// decalre the variables for global scope
        /// </summary>
        string strOrig;
        string strFind;
        string strReplace;
        string newStr;
        
        
        public Form1()
        {
            InitializeComponent();
            

        }

        private void btnChangeIt_Click(object sender, EventArgs e)
        {
            strOrig = tbxStrOrig.Text.Trim();
            strFind = tbxStrFind.Text.Trim();
            strReplace = tbxStrReplace.Text.Trim();

            

            
            
            ReplaceString(strOrig, strFind, strReplace, out newStr);

            // send text to empty Text property on lblnewStr for display 
            lblnewStr.Text = newStr;
            ResetInput();
        }


        //method for string replacement procedure
        private void ReplaceString( string strOrig,  string strFind, string strReplace, out string newStr)
        {
            string x = strOrig;
            string y = strFind;
            string z = strReplace;
            char a;
            char b;
            // newStr = x.Replace(y, z); for testing and building UI

            string[] origArr;
            char[] charArr;

            if (x.Contains(' '))
            {
                origArr = x.Split(' ');
                
                for (var i = 0; i < origArr.Length; i++)
                {
                    if (origArr[i] ==y)
                    {
                        origArr[i] = z;
                    }
                }
                 newStr = string.Join(" ", origArr);
            }
            else
            {
                charArr = x.ToCharArray();
                a =  strFind[0];
                b = strReplace[0];
                
                for (var i = 0; i < charArr.Length; i++)
                {
                    if (charArr[i] == a)
                    {
                        charArr[i] = b;
                    }
                    
                }
                newStr = String.Concat(charArr);
            }
           


        }

        //method that empties the text box after new string is created.
        private void ResetInput()
        {
            tbxStrOrig.Text = string.Empty;
            tbxStrFind.Text = string.Empty;
            tbxStrReplace.Text = string.Empty;
            tbxStrOrig.Focus();
        }
    }
}
