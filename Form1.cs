/*                                               بسم الله الرحمن الرحيم
     هذا البرنامج البسيط يقوم بإيجاد أرقام واحرف ورموز عشوائية بالاستعانة بـ
     Random Class
     ويمكن استخدامه لتوليد كلمات مرور مختلفة في كل مرة
     وقد تم الأخذ بعين الإعتبار إمكانية استخدام جميع الرموز المسموح استخدامها في كلمات المرور بالمواقع العالمية
*/
using System; 
using System.Collections.Generic;  
using System.ComponentModel;
using System.Data;
using System.Drawing;  
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Password
{
    public partial class Form1 : Form
    {
        int num; // لتحديد عدد خانات كلمة المرور
        public Form1()
        {
            InitializeComponent();
        }
        public void mess()  // تابع يتم وضعه في حال عدم تحقق أحد الشروط المطلوبة
        {
            MessageBox.Show("بلا جنون يعني معقول تحط كلمة المرور أطول من 500 خانة!!! 40 خانة بتكفيك وزيادة ",
                            "!!! هيك تخنتها", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            num = 40; // تم وضع 40 تلقائياً بسبب طلب المستخدم وضع رقم فيه أكثر من 500 خانة
            richTextBoxLength.Clear();
            richTextBoxLength.Focus();
        }
        private void buttonFond_Click(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            richTextBoxLength.Focus();

            if (richTextBoxLength.Text.Length != 0) // شرط لمعرفة أن الطول غير خالي من القيم
            {
                if(Convert.ToInt32(richTextBoxLength.Text) < 10) // حتى لا تكون كلمة المرور أقل من 10 خانات
                {
                    MessageBox.Show("بلا جنون يعني معقول تحط كلمة المرور أقصر من 10 خانات!!! بسمحلك بـ10 خانات على أقل تقدير ",
                            "!!! هيك تخنتها", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    num = 10; // تم وضع 10 تلقائياً بسبب طلب المستخدم وضع رقم فيه أقل من 10 خانات
                    richTextBoxLength.Clear();
                    richTextBoxLength.Focus();
                }
                else if (richTextBoxLength.Text.Length >= 4 || Convert.ToInt32(richTextBoxLength.Text) > 500) // شرط لمعرفة أن الطول لا يتجاوز الأربع خانات أو الرقم 500
                {
                    mess();
                }
                else
                    num = Convert.ToInt32(richTextBoxLength.Text); // يأخذ المتغير عدد الخانات من المستخدم
            }
            else num = 20; // يتم أخذ رقم 20 خانة تلقائياً في حالة لم يضع المستخدم رقم خانات معين

            Random rand = new Random(); // تم التعريف عن منغير من نوع (Random) عشوائي
            string[] ranstr = { "A", "B", "C", "D", "E", "F","G", "H", "I", "J", "K", "L", // تم وضع الاحرف والأرقام والرموز
            "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z","a", "b", // المسموح استخدامها في المواقع العالمية
            "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p","q", "r", // وعددهم 90 ولكن يوجد 3 رموز لم أضعها 
            "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5","6", "7", // الرمزان في الأسفل تعذر استخدامهم بسبب حدوث
            "8", "9", "(", ")", "#", "$", "&", "_", "-", "?", "!", "@", "=", "+","/", "%", // أخطاء برمجية عند وضعهم والرمز الاّخر لم أجده
            ":", "'", "*", ".", ",", "[", "]", "{", "}", "~", "^", ">", "<", ";","|"};     // \ " الرمزان الذي تعذر استخدامهم بسبب الخطأ هم  

            for (int i = 0; i < num; i++)
            {
                textBoxPassword.Text = textBoxPassword.Text + ranstr[rand.Next(ranstr.Length)];
                /* 
                 هنا عبارة عن  عداد يتم استخدامه لحساب عدد الخانات التي يتم وضعها
                 الفكرة هنا أنه يتم أخذ الموجود في النص القديم ووضعه مع الجديد وبالنسبة لطريقة الإختيار فإنه يتم وضع المصفوفة
                التي تحوي الرموز ويتم وضع تابع الاختيار العشوائي في مكان فهرس المصفوفة ويتم إعطاء التابع قيمة تساوي طول المصفوفة ناقص واحد
                وهنا عندما يتم اختيار رقم عشوائي في المتغير فإنه سيكون ترتيب للعنصر الموجود في المصفوفة 
                وهكذا يتم اختيار عناصر عشوائية من المصفوفة وانتهى ولله الحمد
                 */
            }
        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            richTextBoxLength.Clear();
            textBoxPassword.Clear();
            richTextBoxLength.Focus();
        }

        private void RandomPassword_Load(object sender, EventArgs e)
        {
            richTextBoxLength.Select();
        }

        private void richTextBoxLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            // هنا يتم تقييد مدخلات النص بالأرقام 
            e.Handled = !(Char.IsDigit(e.KeyChar));
        }

        private void richTextBoxLength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // في حال تم ضغط زر الإدخال (Enter)
            {
                // يتم الغاء عمل الزر (Enter) ويتم استدعاء (buttonFond)
                e.SuppressKeyPress = true; 
                buttonFond.PerformClick();
            }
        }
    }
} 
// انتهى هذا البرنامج البسيط ولله الحمد
