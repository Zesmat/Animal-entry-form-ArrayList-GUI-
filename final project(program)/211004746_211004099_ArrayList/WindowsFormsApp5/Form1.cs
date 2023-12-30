    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Media;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

namespace WindowsFormsApp5
{

    public partial class Form1 : Form
    {
        private int currentImageIndex = 0;
        private string[] imagePaths;

        public MyArrayList arrayl;

        public Form1()
        {
            //initial look of the form
            InitializeComponent();
            InitializeTimer();
            InitializeImagePaths();
          this.FormClosing += Form1_FormClosing;


            arrayl = new MyArrayList();
        }
        private void InitializeImagePaths()
        {
            // Provide paths to your images
            imagePaths = new[]
            {
                @"D:\images\Hero Pedigree Cats.jpg",
                @"D:\images\KOA_Nassau_2697x1517.jpg",
                @"D:\images\220325case013.jpg",
            };

            currentImageIndex = 0;
        }


        private void InitializeTimer()
        {
            imageTimer = new Timer();
            imageTimer.Interval = 4000; // 5 seconds interval
            imageTimer.Tick += imageTimer_Tick;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowImage();

            // Load initial image
            pictureBox1.Image = Image.FromFile(@"D:\images\KOA_Nassau_2697x1517.jpg");

            // Start the timer
            imageTimer.Start();
        }
        private void ShowImage()
        {
            Image img = Image.FromFile(imagePaths[currentImageIndex]);

            // Set the PictureBox properties
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Adjust the size mode as needed
            pictureBox1.Size = new Size(300, 200); // Set the desired size

        }

        private void imageTimer_Tick(object sender, EventArgs e)
        {
            // Increment the image index and loop back to the first image if at the end
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;

            // Show the current image
            ShowImage();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Stop the timer when the form is closed
            imageTimer.Stop();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            //if ((string)inputTextBox.Text == string.Equals("Cat", StringComparison.OrdinalIgnoreCase)) || (string)inputTextBox.Text == "Dog" || (string)inputTextBox.Text == "Bird")
            if (!string.IsNullOrWhiteSpace(inputTextBox.Text) && !string.IsNullOrEmpty(inputTextBox1.Text) && !string.IsNullOrEmpty(inputTextBox2.Text))

            {
                if (string.Equals("Cat", inputTextBox.Text, StringComparison.OrdinalIgnoreCase) || string.Equals("Dog", inputTextBox.Text, StringComparison.OrdinalIgnoreCase)
                    || string.Equals("Bird", inputTextBox.Text, StringComparison.OrdinalIgnoreCase) || string.Equals("Turtle", inputTextBox.Text, StringComparison.OrdinalIgnoreCase)
                    || string.Equals("fish", inputTextBox.Text, StringComparison.OrdinalIgnoreCase) || string.Equals("monkey", inputTextBox.Text, StringComparison.OrdinalIgnoreCase)
                    || string.Equals("hamster", inputTextBox.Text, StringComparison.OrdinalIgnoreCase))

                {
                    arrayl.Add(inputTextBox.Text);
                    UpdateListBox.Items.Add(inputTextBox.Text);
                    arrayl.Add(inputTextBox1.Text);
                    UpdateListBox.Items.Add(inputTextBox1.Text);
                    arrayl.Add(inputTextBox2.Text);
                    UpdateListBox.Items.Add(inputTextBox2.Text);

                    inputTextBox.Clear();
                    inputTextBox1.Clear();
                    inputTextBox2.Clear();

                    WriteToNotepadFile(arrayl);

                }
                else
                {
                    MessageBox.Show("Please enter the given animals only");
                    return;
                }


            } 
            else
                {
                    MessageBox.Show("Please enter the all fields ");
                    return;
                }
            
            
        }
        private void WriteToNotepadFile(MyArrayList data)
        {
            // Specify the path to the notepad file
            //string relativePath = @"animal.txt";
          //  string filePath = Path.Combine(Application.StartupPath, relativePath);//Placing the the path same as the application
          string filePath = @"C:\Users\Legion\Documents\GitHub\Animal-entry-form-ArrayList-GUI-\final project(program)\211004746_211004099_ArrayList\WindowsFormsApp5\animal.txt";

            try
            {
                // Write each item from the arrayl to the file
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    foreach (object item in data)
                    {
                        if (item != null)
                        {
                            writer.WriteLine(item.ToString());// add text in file
                        }
                      
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        //delete button
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (UpdateListBox.SelectedItem != null)
            {
                string selectedItem = UpdateListBox.SelectedItem.ToString();

                // Remove from the array list
                arrayl._Remove(selectedItem);

                // Remove from the ListBox
                UpdateListBox.Items.Remove(selectedItem);

                // Remove from the file
                RemoveLineFromFile(selectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //delete text from the file
        private void RemoveLineFromFile(string lineToRemove)
        {
            string filePath = @"C:\Users\Legion\Documents\GitHub\Animal-entry-form-ArrayList-GUI-\final project(program)\211004746_211004099_ArrayList\WindowsFormsApp5\animal.txt";
            //string relativePath = @"animal.txt";
            //string filePath = Path.Combine(Application.StartupPath, relativePath);//Placing the the path same as the application
            try
            {
                // Read all lines from the file except the line that needed to be removed(lineToRemove)
                string[] lines = File.ReadAllLines(filePath).Where(line => line != lineToRemove).ToArray();

                // Write back to the file
                File.WriteAllLines(filePath, lines);

                MessageBox.Show("Item removed from the file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while removing from file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text;

            int index = arrayl.PerformSearch(searchTerm);

            if (index != -1)
            {
                listBox.Items.Clear();
                listBox.Items.Add(arrayl[index]); // Add the searched text to the Listbox

               // MessageBox.Show($"Item found at index {index}");
                UpdateListBox.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("Item not found");
            }
        }
        public bool isSoundOn = true;
        private SoundPlayer soundPlayer;
        private void Make_Sound_Click(object sender, EventArgs e)
        {
            isSoundOn = !isSoundOn;
            if (isSoundOn)
            {
                Make_Sound.Text = "OFF";
                soundPlayer?.Stop();
            }
            else
            {
                Make_Sound.Text = "ON";
                string relativePath = @"Christmas-music-box-carol.wav";
                string fullPath = Path.Combine(Application.StartupPath, relativePath);//Placing the the path same as the application

                if (File.Exists(fullPath))
                {
                    if (soundPlayer == null)
                    {
                        soundPlayer = new SoundPlayer(fullPath);
                    }
                    soundPlayer.Play();
                }
                else
                {
                    MessageBox.Show("Sound file not found.");
                }
                
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (UpdateListBox.SelectedItem != null)
            {
                int selectedIndex = UpdateListBox.SelectedIndex;
                string currentItem = UpdateListBox.SelectedItem.ToString();

                // Show the custom dialog form to get the new value
                using (UpdateValueForm updateForm = new UpdateValueForm(currentItem))
                {
                    if (updateForm.ShowDialog() == DialogResult.OK)
                    {
                        string newValue = updateForm.NewValue;

                        // Update the value in the array list
                        arrayl.Update(selectedIndex, newValue);

                        // Update the value in the ListBox
                        UpdateListBox.Items[selectedIndex] = newValue;



                        MessageBox.Show("Item updated successfully.");
                        UpdateValueInFile(currentItem, newValue);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateValueInFile(string oldValue, string newValue)
        {
            //string filePath = Path.Combine(Application.StartupPath, "animal.txt");
            string filePath = @"C:\Users\Legion\Documents\GitHub\Animal-entry-form-ArrayList-GUI-\final project(program)\211004746_211004099_ArrayList\WindowsFormsApp5\animal.txt";

            try
            {
                // Read all lines from the file into a list
                List<string> lines = File.ReadAllLines(filePath).ToList();

                // Find and update the line
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i] == oldValue)
                    {
                        lines[i] = newValue;
                        break;
                    }
                }

                // Write back to the file
                File.WriteAllLines(filePath, lines);

                MessageBox.Show("File updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //used to clear all data inside the file
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //string filePath = Path.Combine(Application.StartupPath, "animal.txt");
            string filePath = @"C:\Users\Legion\Documents\GitHub\Animal-entry-form-ArrayList-GUI-\final project(program)\211004746_211004099_ArrayList\WindowsFormsApp5\animal.txt";
            try
            {
                // Create or overwrite the file to clear its content
                File.WriteAllText(filePath, string.Empty);
                MessageBox.Show("File data cleared successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while clearing file data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void UpdateListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
    




