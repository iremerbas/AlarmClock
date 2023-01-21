using System.Media;
using System.Security.Claims;

namespace CalarSaat
{
    public partial class Form1 : Form
    {
        SoundPlayer sound;
        bool clockStatus=false;
        int clockTimer = 0;
        int dateId = 0;
        int alarmId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clockLbl.Text = DateTime.Now.ToString("HH:mm:ss");

            foreach (var alarm in DbContext.AlarmList.ToList())
            {
                if (alarm.Date == clockLbl.Text)
                {
                    clockStatus = true;
                    sound = new SoundPlayer(@"C:\Users\Dell\Downloads\repos\CalarSaat\CalarSaat\Sounds\" + alarm.AlarmSound + ".wav");
                    sound.Play();
                    dateId = alarm.Id;
                }
            }
            if (clockStatus)
            {
                clockTimer++;
                label4.Visible = true;
                if (clockTimer % 4 != 0)
                {
                    label4.Text = "Alarm Çalıyor.";
                }
                else
                {
                    label4.Text = "";
                }

                if (clockTimer == 40)
                {
                    
                    sound.Stop();
                    clockTimer = 0;
                    clockStatus = false;
                    label4.Text = "";

                    foreach (var alarm in DbContext.AlarmList.ToList())
                    {
                        if (alarm.Id == dateId)
                        {
                            DbContext.AlarmList.Remove(alarm);
                            AlarmList();
                        }
                    }
                }
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            comboBox1.Items.Add("Alarm_Sesi_1");
            comboBox1.Items.Add("Alarm_Sesi_2");
            comboBox1.Items.Add("Alarm_Sesi_3");
            comboBox1.Items.Add("bambam");
        }

        public void AlarmList()
        {
            
            alarmListLb.Items.Clear();
            foreach (var alarm in DbContext.AlarmList.ToList())
            {
                alarmListLb.Items.Add(alarm.Date+" "+alarm.AlarmSound);
            }
        }

        private void alarmAddBtn_Click(object sender, EventArgs e)
        {
            if (DbContext.AlarmList.Count < 5)
            {

          
            alarmId++;
            Alarm alarm = new Alarm()
            {
                Id=alarmId,
                Date = textBox1.Text,
                AlarmSound = comboBox1.SelectedItem.ToString()
            };

            DbContext.AlarmList.Add(alarm);

            AlarmList();
            }
            else
            {
                MessageBox.Show("Alarm Sayısı 5'ten Fazla Olamaz");
            }
        }

        private void alarmDeleteBtn_Click(object sender, EventArgs e)
        {
            string selectDate=alarmListLb.SelectedItem.ToString();
            string[] date = selectDate.Split(" ");
            foreach (var alarm in DbContext.AlarmList.ToList())
            {
                if (alarm.Date == date[0])
                {
                    DbContext.AlarmList.Remove(alarm);
                    AlarmList();
                    break;

                }
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            sound.Stop();
        }
    }
}