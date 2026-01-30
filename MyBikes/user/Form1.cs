using MyBikes.bus;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace MyBikes
{
    public partial class Form1 : Form
    {
        //Declare and create 5 lists
        List<Bike>? listOfBikes = new List<Bike>();
        List<Road>? listOfRoads = new List<Road>();
        List<Mountain>? listOfMountains = new List<Mountain>();
        List<Electric>? listOfElectrics = new List<Electric>();
        List<Hybrid>? listOfHybrids = new List<Hybrid>();

        //Declare 5 instances (5 objects or 5 references variables)
        Bike currentBike;
        Road currentRoad;
        Mountain currentMountain;
        Electric currentElectric;
        Hybrid currentHybrid;

        //Deckare an instance of the date class (an object of the datatype)
        Date currentMadeDate;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //variables delcaration
            int serialNumber;
            int made;
            string model;
            double speed;
            double wheelSize;
            int currentDay, currentMonth, currentYear;

            try
            {
                currentMadeDate = new Date();

                //Bike Type
                EnumBikeType currentBikeType;
                Enum.TryParse(this.comboBoxBikeType.Text, out currentBikeType);

                //Frame Type
                EnumFrameType currentFrameType;
                Enum.TryParse(this.comboBoxFrameType.Text, out currentFrameType);

                //Color
                EnumColor currentColor;
                Enum.TryParse(this.comboBoxColor.Text, out currentColor);

                //Bike features
                serialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                made = Convert.ToInt32(this.textBoxMade.Text);
                model = this.textBoxModel.Text;
                speed = Convert.ToDouble(this.textBoxSpeed.Text);
                wheelSize = Convert.ToDouble(this.textBoxWheelSize.Text);

                //Made Date
                currentDay = Convert.ToInt32(this.textBoxDay.Text);
                currentMonth = Convert.ToInt32(this.textBoxMonth.Text);
                currentYear = Convert.ToInt32(this.textBoxYear.Text);

                currentMadeDate.Day = currentDay;
                currentMadeDate.Month = currentMonth;
                currentMadeDate.Year = currentYear;
                //To make sure the date is correct (we implement the IsValidDate method)
                if (!currentMadeDate.IsValidDate())
                {
                    MessageBox.Show("The date you input is not correct, please insert another one", "Invalid Date!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Road 
                if (currentBikeType == EnumBikeType.Road)
                {
                    currentRoad = new Road();

                    currentRoad.Type = currentBikeType;
                    currentRoad.SerialNumber = serialNumber;
                    currentRoad.Made = made;
                    currentRoad.Model = model;
                    currentRoad.Speed = speed;
                    currentRoad.WheelSize = wheelSize;
                    currentRoad.FrameType = currentFrameType;
                    currentRoad.Color = currentColor;
                    currentRoad.MadeDate = currentMadeDate;

                    try
                    {
                        currentRoad.SeatHeight = Convert.ToDouble(this.textBoxSeatHeight.Text);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (DataCollection.ListOfBikes != null)
                    {
                        if (speed <= currentRoad.GetMaxSpeed())
                        {
                            DataCollection.Add(currentRoad);
                        }

                        else
                        {
                            MessageBox.Show($"The speed ({speed} km/h) exceeds the maximum speed of the bike ({currentRoad.GetMaxSpeed()} km/h). \nIt must be changed", "Bike's Seed Test",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                else if (currentBikeType == EnumBikeType.Mountain)
                {
                    currentMountain = new Mountain();

                    currentMountain.Type = currentBikeType;
                    currentMountain.SerialNumber = serialNumber;
                    currentMountain.Made = made;
                    currentMountain.Model = model;
                    currentMountain.Speed = speed;
                    currentMountain.WheelSize = wheelSize;
                    currentMountain.FrameType = currentFrameType;
                    currentMountain.Color = currentColor;
                    currentMountain.MadeDate = currentMadeDate;

                    try
                    {
                        currentMountain.HeightFromGround = Convert.ToDouble(this.textBoxHeightFromGround.Text);
                        EnumSuspension currentSuspension;
                        Enum.TryParse(this.comboBoxSuspension.Text, out currentSuspension);
                        currentMountain.Suspension = currentSuspension;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (DataCollection.ListOfBikes != null)
                    {
                        if (speed <= currentMountain.GetMaxSpeed())
                        {
                            DataCollection.Add(currentMountain);
                        }

                        else
                        {
                            MessageBox.Show($"The speed ({speed} km/h) exceeds the maximum speed of the bike ({currentMountain.GetMaxSpeed()} km/h). \nIt must be changed", "Bike's Seed Test",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                else if (currentBikeType == EnumBikeType.Electric)
                {
                    currentElectric = new Electric();

                    currentElectric.Type = currentBikeType;
                    currentElectric.SerialNumber = serialNumber;
                    currentElectric.Made = made;
                    currentElectric.Model = model;
                    currentElectric.Speed = speed;
                    currentElectric.WheelSize = wheelSize;
                    currentElectric.FrameType = currentFrameType;
                    currentElectric.Color = currentColor;
                    currentElectric.MadeDate = currentMadeDate;

                    try
                    {
                        currentElectric.BatteryIndicator = Convert.ToInt32(this.textBoxBatteryIndicator.Text);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (DataCollection.ListOfBikes != null)
                    {
                        if (speed <= currentElectric.GetMaxSpeed())
                        {
                            DataCollection.Add(currentElectric);
                        }

                        else
                        {
                            MessageBox.Show($"The speed ({speed} km/h) exceeds the maximum speed of the bike ({currentElectric.GetMaxSpeed()} km/h). \nIt must be changed", "Bike's Seed Test",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                else if (currentBikeType == EnumBikeType.Hybrid)
                {
                    currentHybrid = new Hybrid();

                    currentHybrid.Type = currentBikeType;
                    currentHybrid.SerialNumber = serialNumber;
                    currentHybrid.Made = made;
                    currentHybrid.Model = model;
                    currentHybrid.Speed = speed;
                    currentHybrid.WheelSize = wheelSize;
                    currentHybrid.FrameType = currentFrameType;
                    currentHybrid.Color = currentColor;
                    currentHybrid.MadeDate = currentMadeDate;

                    try
                    {
                        EnumHybridType currentHybridType;
                        Enum.TryParse(this.comboBoxHybridType.Text, out currentHybridType);
                        currentHybrid.HybridType = currentHybridType;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (DataCollection.ListOfBikes != null)
                    {
                        if (speed <= currentHybrid.GetMaxSpeed())
                        {
                            DataCollection.Add(currentHybrid);
                        }

                        else
                        {
                            MessageBox.Show($"The speed ({speed} km/h) exceeds the maximum speed of the bike ({currentHybrid.GetMaxSpeed()} km/h). \nIt must be changed", "Bike's Seed Test",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \t You must input a valid data");
                this.textBoxSerialNumber.Focus();
            }
        }

        private void buttonPrintBikes_Click(object sender, EventArgs e)
        {
            this.listBoxBikes.Items.Clear();

            if (DataCollection.GetBikeList != null && DataCollection.GetBikeList().Count > 0 && this.listBoxBikes.Items.Count == 0)
            {
                foreach (Bike currentBike in DataCollection.GetBikeList())
                {
                    if (currentBike is Road)
                    {
                        currentRoad = (Road)currentBike;
                        this.listBoxBikes.Items.Add(currentRoad.GetState());
                    }

                    else if (currentBike is Mountain)
                    {
                        currentMountain = (Mountain)currentBike;
                        this.listBoxBikes.Items.Add(currentMountain.GetState());
                    }

                    else if (currentBike is Electric)
                    {
                        currentElectric = (Electric)currentBike;
                        this.listBoxBikes.Items.Add(currentElectric.GetState());
                    }

                    else if (currentBike is Hybrid)
                    {
                        currentHybrid = (Hybrid)currentBike;
                        this.listBoxBikes.Items.Add(currentHybrid.GetState());
                    }
                }
            }

            else
            {
                MessageBox.Show("The list of bikes are already printed in the listBox or the list of item in memory is empty...", "To Print a Bike:",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.comboBoxBikeType.Text = EnumBikeType.Undefined.ToString();
            this.comboBoxFrameType.Text = EnumFrameType.Undefined.ToString();
            this.comboBoxColor.Text = EnumColor.Undefined.ToString();

            this.textBoxSerialNumber.Text = string.Empty;
            this.textBoxMade.Text = string.Empty;
            this.textBoxModel.Text = string.Empty;
            this.textBoxSpeed.Text = string.Empty;
            this.textBoxWheelSize.Text = string.Empty;

            this.textBoxDay.Text = string.Empty;
            this.textBoxMonth.Text = string.Empty;
            this.textBoxYear.Text = string.Empty;

            this.textBoxSeatHeight.Text = string.Empty;
            this.comboBoxSuspension.Text = EnumSuspension.Undefined.ToString();
            this.textBoxHeightFromGround.Text = string.Empty;
            this.textBoxBatteryIndicator.Text = string.Empty;
            this.comboBoxHybridType.Text = EnumHybridType.Undefined.ToString();

            this.textBoxSerialNumber.Focus();

            this.listBoxBikes.Items.Clear();

            this.buttonAdd.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application written by Alvaro Limaymanta Soria", "Event Programming with C#",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //Check if the textBox is empty
            if (string.IsNullOrEmpty(textBoxSerialNumber.Text))
            {
                MessageBox.Show($"Insert the Serial Number of a Bike to Search", "To Search a Bike:",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool found = false;
            Bike bikeToSearch = null;

            Road currentRoad;
            Mountain currentMountain;
            Electric currentElectric;
            Hybrid currentHybrid;

            if (DataCollection.GetBikeList != null)
            {
                foreach (Bike currentBike in DataCollection.GetBikeList())
                {
                    if (currentBike.SerialNumber == Convert.ToInt32(this.textBoxSerialNumber.Text))
                    {
                        found = true;
                        bikeToSearch = currentBike;
                        break;
                    }
                }
            }

            if (found)
            {
                if (bikeToSearch.Type == EnumBikeType.Road)
                {
                    currentRoad = (Road)bikeToSearch; //Casting
                    MessageBox.Show("Road Bike Found! \n" + currentRoad.GetState(),
                    "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.listBoxBikes.Items.Add(currentRoad.GetState());
                }

                else if (bikeToSearch.Type == EnumBikeType.Mountain)
                {
                    currentMountain = (Mountain)bikeToSearch; //Casting
                    MessageBox.Show("Mountain Bike Found! \n" + currentMountain.GetState(),
                    "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.listBoxBikes.Items.Add(currentMountain.GetState());
                }

                else if (bikeToSearch.Type == EnumBikeType.Electric)
                {
                    currentElectric = (Electric)bikeToSearch; //Casting
                    MessageBox.Show("Electric Bike Found! \n" + currentElectric.GetState(),
                    "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.listBoxBikes.Items.Add(currentElectric.GetState());
                }

                else if (bikeToSearch.Type == EnumBikeType.Hybrid)
                {
                    currentHybrid = (Hybrid)bikeToSearch; //Casting
                    MessageBox.Show("Hybrid Bike Found! \n" + currentHybrid.GetState(),
                    "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.listBoxBikes.Items.Add(currentHybrid.GetState());
                }
            }

            else
            {
                MessageBox.Show("Bike not found...",
                "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (EnumColor bike in Enum.GetValues(typeof(EnumColor)))
            {
                this.comboBoxColor.Items.Add(bike);
            }
            this.comboBoxColor.Text = Convert.ToString(EnumColor.Undefined);

            foreach (EnumBikeType bike in Enum.GetValues(typeof(EnumBikeType)))
            {
                this.comboBoxBikeType.Items.Add(bike);
            }
            this.comboBoxBikeType.Text = Convert.ToString(EnumBikeType.Undefined);

            foreach (EnumSuspension suspension in Enum.GetValues(typeof(EnumSuspension)))
            {
                this.comboBoxSuspension.Items.Add(suspension);
            }
            this.comboBoxSuspension.Text = Convert.ToString(EnumSuspension.Undefined);

            foreach (EnumFrameType frameType in Enum.GetValues(typeof(EnumFrameType)))
            {
                this.comboBoxFrameType.Items.Add(frameType);
            }
            this.comboBoxFrameType.Text = Convert.ToString(EnumFrameType.Undefined);

            foreach (EnumHybridType hybridType in Enum.GetValues(typeof(EnumHybridType)))
            {
                this.comboBoxHybridType.Items.Add(hybridType);
            }
            this.comboBoxHybridType.Text = Convert.ToString(EnumHybridType.Undefined);
        }

        int currentIndex = -1;
        private void listBoxBikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentIndex = this.listBoxBikes.SelectedIndex;

            EnumBikeType currentBikeType;

            this.listOfBikes = DataCollection.GetBikeList();

            if (this.listOfBikes != null && currentIndex >= 0 && currentIndex < this.listOfBikes.Count)
            {
                currentBikeType = this.listOfBikes[currentIndex].Type;

                this.comboBoxBikeType.Text = Convert.ToString(currentBikeType);

                if (currentIndex >= 0 && currentBikeType == EnumBikeType.Road)
                {
                    Road currentRoad = new Road();

                    currentRoad = (Road)this.listOfBikes[currentIndex];

                    this.textBoxSerialNumber.Text = currentRoad.SerialNumber.ToString();
                    this.textBoxMade.Text = currentRoad.Made.ToString();
                    this.textBoxModel.Text = currentRoad.Model.ToString();
                    this.textBoxSpeed.Text = currentRoad.Speed.ToString();
                    this.textBoxWheelSize.Text = currentRoad.WheelSize.ToString();

                    this.comboBoxFrameType.Text = currentRoad.FrameType.ToString();
                    this.comboBoxColor.Text = currentRoad.Color.ToString();

                    this.textBoxDay.Text = currentRoad.MadeDate.Day.ToString();
                    this.textBoxMonth.Text = currentRoad.MadeDate.Month.ToString();
                    this.textBoxYear.Text = currentRoad.MadeDate.Year.ToString();

                    this.textBoxSeatHeight.Text = currentRoad.SeatHeight.ToString();
                }

                else if (currentIndex >= 0 && currentBikeType == EnumBikeType.Mountain)
                {
                    Mountain currentMountain = new Mountain();

                    currentMountain = (Mountain)this.listOfBikes[currentIndex];

                    this.textBoxSerialNumber.Text = currentMountain.SerialNumber.ToString();
                    this.textBoxMade.Text = currentMountain.Made.ToString();
                    this.textBoxModel.Text = currentMountain.Model.ToString();
                    this.textBoxSpeed.Text = currentMountain.Speed.ToString();
                    this.textBoxWheelSize.Text = currentMountain.WheelSize.ToString();

                    this.comboBoxFrameType.Text = currentMountain.FrameType.ToString();
                    this.comboBoxColor.Text = currentMountain.Color.ToString();

                    this.textBoxDay.Text = currentMountain.MadeDate.Day.ToString();
                    this.textBoxMonth.Text = currentMountain.MadeDate.Month.ToString();
                    this.textBoxYear.Text = currentMountain.MadeDate.Year.ToString();

                    this.comboBoxSuspension.Text = currentMountain.Suspension.ToString();
                    this.textBoxHeightFromGround.Text = currentMountain.HeightFromGround.ToString();
                }

                else if (currentIndex >= 0 && currentBikeType == EnumBikeType.Electric)
                {
                    Electric currentElectric = new Electric();

                    currentElectric = (Electric)this.listOfBikes[currentIndex];

                    this.textBoxSerialNumber.Text = currentElectric.SerialNumber.ToString();
                    this.textBoxMade.Text = currentElectric.Made.ToString();
                    this.textBoxModel.Text = currentElectric.Model.ToString();
                    this.textBoxSpeed.Text = currentElectric.Speed.ToString();
                    this.textBoxWheelSize.Text = currentElectric.WheelSize.ToString();

                    this.comboBoxFrameType.Text = currentElectric.FrameType.ToString();
                    this.comboBoxColor.Text = currentElectric.Color.ToString();

                    this.textBoxDay.Text = currentElectric.MadeDate.Day.ToString();
                    this.textBoxMonth.Text = currentElectric.MadeDate.Month.ToString();
                    this.textBoxYear.Text = currentElectric.MadeDate.Year.ToString();

                    this.textBoxBatteryIndicator.Text = currentElectric.BatteryIndicator.ToString();
                }

                else if (currentIndex >= 0 && currentBikeType == EnumBikeType.Hybrid)
                {
                    Hybrid currentHybrid = new Hybrid();

                    currentHybrid = (Hybrid)this.listOfBikes[currentIndex];

                    this.textBoxSerialNumber.Text = currentHybrid.SerialNumber.ToString();
                    this.textBoxMade.Text = currentHybrid.Made.ToString();
                    this.textBoxModel.Text = currentHybrid.Model.ToString();
                    this.textBoxSpeed.Text = currentHybrid.Speed.ToString();
                    this.textBoxWheelSize.Text = currentHybrid.WheelSize.ToString();

                    this.comboBoxFrameType.Text = currentHybrid.FrameType.ToString();
                    this.comboBoxColor.Text = currentHybrid.Color.ToString();

                    this.textBoxDay.Text = currentHybrid.MadeDate.Day.ToString();
                    this.textBoxMonth.Text = currentHybrid.MadeDate.Month.ToString();
                    this.textBoxYear.Text = currentHybrid.MadeDate.Year.ToString();

                    this.comboBoxHybridType.Text = currentHybrid.HybridType.ToString();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            EnumBikeType currentBikeType;
            Enum.TryParse(this.comboBoxBikeType.Text, out currentBikeType);

            if (DataCollection.ListOfBikes != null && currentIndex >= 0 && currentIndex < DataCollection.ListOfBikes.Count) //if we do not select a counter the message will appear without errors
            {
                currentBikeType = DataCollection.ListOfBikes[currentIndex].Type;
            }

            if (currentIndex >= 0 && listOfBikes != null)
            {
                Date currentDate = new Date();
                currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);

                //To make sure the date is correct (we implement the IsValidDate method)
                if (!currentDate.IsValidDate())
                {
                    MessageBox.Show("The date you input to update is not a valid one, please insert another one", "Invalid Date!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (currentBikeType == EnumBikeType.Road)
                {
                    Road currentRoad = new Road();

                    currentRoad.Type = currentBikeType;
                    currentRoad.SerialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                    currentRoad.Made = Convert.ToInt32(this.textBoxMade.Text);
                    currentRoad.Model = this.textBoxModel.Text;
                    currentRoad.Speed = Convert.ToDouble(this.textBoxSpeed.Text);
                    currentRoad.WheelSize = Convert.ToDouble(this.textBoxWheelSize.Text);

                    EnumFrameType currentFrameType;
                    Enum.TryParse(this.comboBoxFrameType.Text, out currentFrameType);
                    currentRoad.FrameType = currentFrameType;

                    EnumColor currentColor;
                    Enum.TryParse(this.comboBoxColor.Text, out currentColor);
                    currentRoad.Color = currentColor;

                    currentRoad.MadeDate = currentDate;

                    currentRoad.SeatHeight = Convert.ToDouble(this.textBoxSeatHeight.Text);

                    if (currentRoad.Speed <= currentRoad.GetMaxSpeed())
                    {
                        //Remove the mountain bike at the current index
                        DataCollection.RemoveAt(currentIndex);

                        //Insert the updated bike at the currenIndex
                        DataCollection.InsertAt(currentIndex, currentRoad);
                    }

                    else
                    {
                        MessageBox.Show($"The speed ({currentRoad.Speed} km/h) exceeds the maximum speed of the bike ({currentRoad.GetMaxSpeed()} km/h). \nYou can not do this update", "Bike's Seed Test",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (currentBikeType == EnumBikeType.Mountain)
                {
                    Mountain currentMountain = new Mountain();

                    currentMountain.Type = currentBikeType;
                    currentMountain.SerialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                    currentMountain.Made = Convert.ToInt32(this.textBoxMade.Text);
                    currentMountain.Model = this.textBoxModel.Text;
                    currentMountain.Speed = Convert.ToDouble(this.textBoxSpeed.Text);
                    currentMountain.WheelSize = Convert.ToDouble(this.textBoxWheelSize.Text);

                    EnumFrameType currentFrameType;
                    Enum.TryParse(this.comboBoxFrameType.Text, out currentFrameType);
                    currentMountain.FrameType = currentFrameType;

                    EnumColor currentColor;
                    Enum.TryParse(this.comboBoxColor.Text, out currentColor);
                    currentMountain.Color = currentColor;

                    currentMountain.MadeDate = currentDate;

                    EnumSuspension currentSuspension;
                    Enum.TryParse(this.comboBoxSuspension.Text, out currentSuspension);
                    currentMountain.Suspension = currentSuspension;

                    currentMountain.HeightFromGround = Convert.ToDouble(this.textBoxHeightFromGround.Text);

                    if (currentMountain.Speed <= currentMountain.GetMaxSpeed())
                    {
                        //Remove the mountain bike at the current index
                        DataCollection.RemoveAt(currentIndex);

                        //Insert the updated bike at the currenIndex
                        DataCollection.InsertAt(currentIndex, currentMountain);
                    }

                    else
                    {
                        MessageBox.Show($"The speed ({currentMountain.Speed} km/h) exceeds the maximum speed of the bike ({currentMountain.GetMaxSpeed()} km/h). \nYou can not do this update", "Bike's Seed Test",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (currentBikeType == EnumBikeType.Electric)
                {
                    Electric currentElectric = new Electric();

                    currentElectric.Type = currentBikeType;
                    currentElectric.SerialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                    currentElectric.Made = Convert.ToInt32(this.textBoxMade.Text);
                    currentElectric.Model = this.textBoxModel.Text;
                    currentElectric.Speed = Convert.ToDouble(this.textBoxSpeed.Text);
                    currentElectric.WheelSize = Convert.ToDouble(this.textBoxWheelSize.Text);

                    EnumFrameType currentFrameType;
                    Enum.TryParse(this.comboBoxFrameType.Text, out currentFrameType);
                    currentElectric.FrameType = currentFrameType;

                    EnumColor currentColor;
                    Enum.TryParse(this.comboBoxColor.Text, out currentColor);
                    currentElectric.Color = currentColor;

                    currentElectric.MadeDate = currentDate;

                    currentElectric.BatteryIndicator = Convert.ToInt32(this.textBoxBatteryIndicator.Text);

                    if (currentElectric.Speed <= currentElectric.GetMaxSpeed())
                    {
                        //Remove the mountain bike at the current index
                        DataCollection.RemoveAt(currentIndex);

                        //Insert the updated bike at the currenIndex
                        DataCollection.InsertAt(currentIndex, currentElectric);
                    }

                    else
                    {
                        MessageBox.Show($"The speed ({currentElectric.Speed} km/h) exceeds the maximum speed of the bike ({currentElectric.GetMaxSpeed()} km/h). \nYou can not do this update", "Bike's Seed Test",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (currentBikeType == EnumBikeType.Hybrid)
                {
                    Hybrid currentHybrid = new Hybrid();

                    currentHybrid.Type = currentBikeType;
                    currentHybrid.SerialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                    currentHybrid.Made = Convert.ToInt32(this.textBoxMade.Text);
                    currentHybrid.Model = this.textBoxModel.Text;
                    currentHybrid.Speed = Convert.ToDouble(this.textBoxSpeed.Text);
                    currentHybrid.WheelSize = Convert.ToDouble(this.textBoxWheelSize.Text);

                    EnumFrameType currentFrameType;
                    Enum.TryParse(this.comboBoxFrameType.Text, out currentFrameType);
                    currentHybrid.FrameType = currentFrameType;

                    EnumColor currentColor;
                    Enum.TryParse(this.comboBoxColor.Text, out currentColor);
                    currentHybrid.Color = currentColor;

                    currentHybrid.MadeDate = currentDate;

                    EnumHybridType currentHybridType;
                    Enum.TryParse(this.comboBoxHybridType.Text, out currentHybridType);
                    currentHybrid.HybridType = currentHybridType;

                    if (currentHybrid.Speed <= currentHybrid.GetMaxSpeed())
                    {
                        //Remove the mountain bike at the current index
                        DataCollection.RemoveAt(currentIndex);

                        //Insert the updated bike at the currenIndex
                        DataCollection.InsertAt(currentIndex, currentHybrid);
                    }

                    else
                    {
                        MessageBox.Show($"The speed ({currentHybrid.Speed} km/h) exceeds the maximum speed of the bike ({currentHybrid.GetMaxSpeed()} km/h). \nYou can not do this update", "Bike's Seed Test",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else
            {
                MessageBox.Show("Select from the ListBox the Bike to Update", "To Update a Bike:",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.listBoxBikes.Items.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && this.listOfBikes != null)
            {
                DataCollection.ListOfBikes.RemoveAt(currentIndex);
                MessageBox.Show("The selected bike has been removed from the list of bikes in memory");
                this.listBoxBikes.Items.Clear();
            }

            else
            {
                MessageBox.Show("Choose from the ListBox the Bike to Remove", "To Remove a Bike:",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.listBoxBikes.Items.Clear();
        }

        private void buttonWriteToXmlFile_Click(object sender, EventArgs e)
        {
            if (DataCollection.ListOfBikes != null)
            {
                FileManager.SerializeToXMLFile(DataCollection.ListOfBikes);
            }
        }

        private void buttonReadFromXmlFile_Click(object sender, EventArgs e)
        {
            this.listOfBikes.Clear();

            DataCollection.ListOfBikes = FileManager.DeserializeFromXmlFile();

            if ((DataCollection.ListOfBikes = FileManager.DeserializeFromXmlFile()) != null)
            {
                foreach (Bike currentBike in DataCollection.ListOfBikes)
                {
                    if (currentBike is Road)
                    {
                        currentRoad = (Road)currentBike;

                        this.listBoxBikes.Items.Add(currentRoad.GetState());
                    }

                    else if (currentBike is Mountain)
                    {
                        currentMountain = (Mountain)currentBike;

                        this.listBoxBikes.Items.Add(currentMountain.GetState());
                    }

                    else if (currentBike is Electric)
                    {
                        currentElectric = (Electric)currentBike;

                        this.listBoxBikes.Items.Add(currentElectric.GetState());
                    }

                    else if (currentBike is Hybrid)
                    {
                        currentHybrid = (Hybrid)currentBike;

                        this.listBoxBikes.Items.Add(currentHybrid.GetState());
                    }
                }
            }
        }

        private void comboBoxBikeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnumBikeType currentBikeType;

            Enum.TryParse(this.comboBoxBikeType.Text, out currentBikeType);

            if (currentBikeType == EnumBikeType.Road)
            {
                this.textBoxSeatHeight.Enabled = true;
                this.comboBoxSuspension.Enabled = false;
                this.textBoxHeightFromGround.Enabled = false;
                this.textBoxBatteryIndicator.Enabled = false;
                this.comboBoxHybridType.Enabled = false;
            }

            else if (currentBikeType == EnumBikeType.Mountain)
            {
                this.textBoxSeatHeight.Enabled = false;
                this.comboBoxSuspension.Enabled = true;
                this.textBoxHeightFromGround.Enabled = true;
                this.textBoxBatteryIndicator.Enabled = false;
                this.comboBoxHybridType.Enabled = false;
            }

            else if (currentBikeType == EnumBikeType.Electric)
            {
                this.textBoxSeatHeight.Enabled = false;
                this.comboBoxSuspension.Enabled = false;
                this.textBoxHeightFromGround.Enabled = false;
                this.textBoxBatteryIndicator.Enabled = true;
                this.comboBoxHybridType.Enabled = false;
            }

            else if (currentBikeType == EnumBikeType.Hybrid)
            {
                this.textBoxSeatHeight.Enabled = false;
                this.comboBoxSuspension.Enabled = false;
                this.textBoxHeightFromGround.Enabled = false;
                this.textBoxBatteryIndicator.Enabled = false;
                this.comboBoxHybridType.Enabled = true;
            }

            else if (currentBikeType == EnumBikeType.Undefined)
            {
                this.textBoxSeatHeight.Enabled = false;
                this.comboBoxSuspension.Enabled = false;
                this.textBoxHeightFromGround.Enabled = false;
                this.textBoxBatteryIndicator.Enabled = false;
                this.comboBoxHybridType.Enabled = false;
            }
        }

        private void buttonPrintRoadBike_Click(object sender, EventArgs e)
        {
            this.listBoxBikes.Items.Clear();

            foreach (Road currentRoad in DataCollection.GetBikeRoadList())
            {
                this.listBoxBikes.Items.Add(currentRoad.GetState());
            }
        }

        private void buttonPrintMountainBike_Click(object sender, EventArgs e)
        {
            this.listBoxBikes.Items.Clear();

            foreach (Mountain currentMountain in DataCollection.GetBikeMountainList())
            {
                this.listBoxBikes.Items.Add(currentMountain.GetState());
            }
        }

        private void buttonPrintElectricBike_Click(object sender, EventArgs e)
        {
            this.listBoxBikes.Items.Clear();

            foreach (Electric currentElectric in DataCollection.GetBikeElectricList())
            {
                this.listBoxBikes.Items.Add(currentElectric.GetState());
            }
        }

        private void buttonPrintHybridBike_Click(object sender, EventArgs e)
        {
            this.listBoxBikes.Items.Clear();

            foreach (Hybrid currentHybrid in DataCollection.GetBikeHybridList())
            {
                this.listBoxBikes.Items.Add(currentHybrid.GetState());
            }
        }

        private Bike GetSelectedBike()
        {
            //Check if any bike is selected in the ListBox
            if (listBoxBikes.SelectedIndex != -1)
            {
                //Get the index of the selected bike
                //retrieves the selected bike form the listBox
                int selectedIndex = listBoxBikes.SelectedIndex;

                //Get the list of bikes from your data collection
                List<Bike> bikes = DataCollection.GetBikeList();

                //Check if the index is within the range of the list (check range)
                if (selectedIndex >= 0 && selectedIndex < bikes.Count)
                {
                    //Return the selected bike
                    return bikes[selectedIndex];
                }
            }

            //If there's no bike selected the index returns null
            return null;
        }

        private void buttonTestSpeedUp_Click(object sender, EventArgs e)
        {
            // Get selected Bike
            Bike selectedBike = GetSelectedBike();

            // If no bike is selected
            if (selectedBike == null)
            {
                MessageBox.Show($"You must choose a bike from the listBox to test speed", "To Test Bike's Speed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double newSpeed = (double)numericUpDownSpeed.Value;
            double currentSpeed = selectedBike.Speed;

            // Calculate the total speed after the speed up
            double totalSpeed = currentSpeed + newSpeed;

            // Check if the total speed exceeds the maximum speed of the bike
            if (totalSpeed > selectedBike.GetMaxSpeed())
            {
                MessageBox.Show($"The speed ({totalSpeed} km/h) exceeds the maximum speed of the bike ({selectedBike.GetMaxSpeed()} km/h). \nYou cannot speed up the bike", "Bike's Speed Test",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedBike.SpeedUp(newSpeed);
            string currentState = selectedBike.GetState();

            // Find the index where the speed  starts
            int speedIndex = currentState.IndexOf("Speed:");

            // Find the end of the speed part
            int endIndex = currentState.IndexOf('|', speedIndex);

            // Extract current speed
            string currentSpeedString = currentState.Substring(speedIndex, endIndex - speedIndex).Trim();

            // Append the new speed string next to the current speed
            string updatedState = currentState.Insert(endIndex,"");

            // Update the selected bike's state in the list box
            int selectedIndex = listBoxBikes.SelectedIndex;
            listBoxBikes.Items[selectedIndex] = updatedState;

            MessageBox.Show($"The speed ({newSpeed} km/h) has been applied to the bike", "Bike's Speed Test",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}