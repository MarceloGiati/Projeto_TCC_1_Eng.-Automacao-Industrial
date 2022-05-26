using Sistem;
namespace WindowsFormsApp2 
{ 
	public partial class Form1 : Form 
{ 

int t1, t2, t3, t4, t5, t6, t7, t8, t9, t10,t11, u1, n1; 
 	
public Form1() 
{ 
InitializeComponent(); 
} 
private void timer3_Tick(object sender, EventArgs e) 
{ 
t9 = Convert.ToInt16(textBox4.Text); 
textBox4.Text = Convert.ToString(t9); 
 
if 	(Convert.ToInt16(textBox2.Text) <= 97 && Convert.ToInt16(textBox4.Text) >= 25) 
 
{ 
t3 = Convert.ToInt16(textBox2.Text) + 1;  	 	 	 	
textBox2.Text = Convert.ToString(t3);  	 	 	 	
button3.BackColor = Color.Green;  	 	 	 	
pictureBox9.Visible = false;  	 	 	 	
pictureBox8.Visible = true;  	 	 	 	
label20.Visible = false;  	 	 	 	
timer7.Enabled = true; 
} 
 	 	 
else if (t3 >= 97) 
{ 
button3.BackColor = Color.Red;  	 	 	 	
timer3.Enabled = false;  	 	 	 	
timer4.Enabled = true;  	 	 	 	
pictureBox8.Visible = false; 
pictureBox9.Visible = true; 
} 
 
else if (Convert.ToInt16(textBox2.Text) < 85 && 
Convert.ToInt16(textBox4.Text) <= 25) 
 
{ 
label20.Visible = true; 
label20.Text = "aguardando nivel de água"; 
} 
 
} 
private void button6_Click(object sender, EventArgs e) 
{ 
textBox1.Text = "25";  	 	 	
textBox2.Text = "75";  	 	
textBox3.Text = "0";  	 	 	
textBox4.Text = "0";  	 	 	
label10.Text = "0"; pictureBox7.Height = 100; 
} 
 
} 
private void label10_Click(object sender, EventArgs e) 
{ 
label10.Visible = false; 
} 
 
private void pictureBox2_Click(object sender, EventArgs e) 
{ 
 
} 
private void button2_Click(object sender, EventArgs e) 
{ 
 	 	 	 
} 
private void textBox1_TextChanged(object sender, EventArgs e) 
{ 
t10 = (Convert.ToInt16(textBox1.Text)); 
if (t10 > 24) 
{ 
label17.Text = "temperatura alta"; 
 	 	 	 	 
} 
 
else if (t10 > 16) 
{ 
label17.Text = "temperatura ok"; 
} 
else 
{ 
label17.Text = "temperatura baixa"; 
 	 	 	 	 
} 
 
} 
private void textBox2_TextChanged(object sender, EventArgs e) 
{ 
u1 = (Convert.ToInt16(textBox2.Text));  	 	 	

if (u1 > 96) 
 
label18.Text = "umidade alta"; 
 
else if (u1 > 86) 
 
label18.Text = "umidade ok"; 
 
else 
 
label18.Text = "umidade baixa"; 
} 
private void textBox4_TextChanged(object sender, EventArgs e) 
{ 
n1 = (Convert.ToInt16(textBox4.Text)); 
if (n1 > 89)  	
label16.Text = "nivel alto"; 
else if (n1 > 26) 
label16.Text = "nivel ok"; 
 
else 
 
label16.Text = "nivel baixo"; 
} 
 
private void timer5_Tick(object sender, EventArgs e) 
{ 
 
if (label10.Text == "0") 
{ 
t5 = Convert.ToInt16(textBox3.Text); 
 
t5++; 

textBox3.Text = Convert.ToString(t5); 
if (t5 > 8) 
{ 
textBox3.Text = "0"; 
button4.BackColor = Color.Green;
pictureBox2.Visible = true;  	
pictureBox1.Visible = false; 
timer6.Enabled = true; 
timer5.Enabled = false; 
} 
 
} 
else 
{ 
button4.BackColor = Color.Green;  
pictureBox2.Visible = true;
pictureBox1.Visible = false;
timer6.Enabled = true; 
timer5.Enabled = false; 
} 
 
} 
private void timer6_Tick(object sender, EventArgs e) 
{ 
t6 = Convert.ToInt16(textBox3.Text); 
 	 	 	 
t6++; 
textBox3.Text = Convert.ToString(t6); 
 	 	 	     
if (t6 > 8) 
{ 
textBox3.Text = "0"; 
button4.BackColor = Color.Red;  
pictureBox1.Visible = true; 
pictureBox2.Visible = false; 
timer6.Enabled = false; 
timer5.Enabled = true; 
} 
label10.Text = textBox3.Text; 
} 
private void timer8_Tick(object sender, EventArgs e) 
{ 
t8 = Convert.ToInt16(textBox4.Text) + 1; textBox4.Text = Convert.ToString(t8); 
pictureBox7.Height--; 
if (t8 >= 90) 
{ 
button5.BackColor = Color.Red; 
timer8.Enabled = false; 
} 
t11 = Convert.ToInt16(textBox2.Text); 
 
if (t11 >= 0) 
{ 
timer7.Enabled = false; 
} 
 
else if (t11 <= 97) 
 
{ 
timer8.Enabled = false; 
timer7.Enabled = true; 
} 
} 
            
private void timer7_Tick(object sender, EventArgs e) 
{ 
t7 = Convert.ToInt16(textBox4.Text) - 1; 
textBox4.Text = Convert.ToString(t7);
pictureBox7.Height++; 
 
if (t7 >= 90) 
{ 
button5.BackColor = Color.Red;
timer8.Enabled = false;
timer7.Enabled = true; 
} 
 
else if (t7 <= 25) 
{ 
button5.BackColor = Color.Green;  
timer7.Enabled = false; 
timer8.Enabled = true; 
} 
} 
private void timer4_Tick(object sender, EventArgs e) 
{ 
t4 = Convert.ToInt16(textBox2.Text) - 1;
textBox2.Text = Convert.ToString(t4); 
timer7.Enabled = false; 
 
if (t4 >= 97) 
{ 
button3.BackColor = Color.Red; 
            
} 
else if (t4 <= 85) 
{ 
timer4.Enabled = false; 
timer3.Enabled = true; 
 	 	 
} 
} 
private void button1_Click(object sender, EventArgs e) 
{ 
if (button1.Text == "LIGA") 
{ 
button1.BackColor = Color.Red;
button1.Text = "DESLIGA"; 
timer1.Enabled = true;
timer4.Enabled = true; 
timer5.Enabled = true;  
timer7.Enabled = true; 
button6.Enabled = false; 
pictureBox1.Visible = true; 
pictureBox2.Visible = false; 	 
} 
 
else if (button1.Text == "DESLIGA") 
{ 
button1.Text = "LIGA";  
button1.BackColor = Color.Green;
timer1.Enabled = false;
timer2.Enabled = false;  
timer3.Enabled = false; 
timer4.Enabled = false;  	 
button2.BackColor = Color.Red;  	 
button3.BackColor = Color.Red;  
button4.BackColor = Color.Red;  
button5.BackColor = Color.Red; 
timer5.Enabled = false;  	 
timer6.Enabled = false;
timer7.Enabled = false;
timer8.Enabled = false;  	
button6.Enabled = true;  
pictureBox1.Visible = true; 
pictureBox2.Visible = false;  	
pictureBox5.Visible = true; 
pictureBox4.Visible = false; 
pictureBox8.Visible = false; 
pictureBox9.Visible = true; 
} 
} 
 
private void timer2_Tick(object sender, EventArgs e) 
{ 
t2 = Convert.ToInt16(textBox1.Text) - 1; 
 
textBox1.Text = Convert.ToString(t2); 
 
(t2 <= 15) 
{ 
button2.BackColor = Color.Red;
timer2.Enabled = false;  
timer1.Enabled = true;
pictureBox5.Visible = true; 
pictureBox4.Visible = false; 
	 } 
} 
private void timer1_Tick(object sender, EventArgs e) { 
t1 = Convert.ToInt16(textBox1.Text) + 1; 
textBox1.Text = Convert.ToString(t1); 
 
if (t1 >= 25) 
{ 
button2.BackColor = Color.Green;  
timer2.Enabled = true;  	 
timer1.Enabled = false; 
pictureBox4.Visible = true; 
pictureBox5.Visible = false; 
} 
 
else if (t1 <= 15) 
{ 
timer2.Enabled = false;  
timer1.Enabled = true;  
button2.BackColor = Color.Red;
pictureBox5.Visible = true; 
pictureBox4.Enabled = false; 
 
} 
 	 	 
 
 
} 
} 
} 
 
 
