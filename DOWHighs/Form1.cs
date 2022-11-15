using System.Text;

namespace DOWHighs
{
    public partial class Form1 : Form
    {
        // The marketAverageList will contain all data read from file
        private List<MarketAverage> marketAverageList = new List<MarketAverage>();

        // The Binding source will be used to bind the marketAverageList to the DataGridView
        private BindingSource source = null;

        // Will keep track of if the list is sorted in ascending order 
        private bool? sortAscending = null;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes and Loads the DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            string line = String.Empty;
            string[] fields;
            MarketAverage marketAverage = null;
            DateTime dateTime;
            decimal closingValue, openingValue, lowValue, highValue;

            // Read the file using a StreamReader
            using (var fs = new FileStream("DJIA.csv", FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    // Read until EOF, i.e., no more lines in file
                    while ((line = sr.ReadLine()) != null)
                    {
                        fields = line.Split(",");

                        // Make sure that we aren't going to have any indexing issues
                        if (fields.Length > 4)
                        {
                            DateTime.TryParse(fields[0], out dateTime);
                            decimal.TryParse(fields[1], out closingValue);
                            decimal.TryParse(fields[2], out openingValue);
                            decimal.TryParse(fields[3], out highValue);
                            decimal.TryParse(fields[4], out lowValue);

                            marketAverage = new MarketAverage(dateTime, closingValue, openingValue,
                                lowValue, highValue);
                            marketAverageList.Add(marketAverage);
                        }
                    }

                    // Add the list as a binding source
                    source = new BindingSource(marketAverageList, null);

                    // Add the binding source as the DataGridView's datasource
                    djiaDataGridView.DataSource = source;
                }
            }


        }

        /// <summary>
        /// Handles the Search Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            decimal closingValue;
            List<MarketAverage> searchResultList = new List<MarketAverage>();
            var enteredValue = closingValueTextBox.Text;
            if (!string.IsNullOrEmpty(enteredValue))
            {
                if (decimal.TryParse(enteredValue, out closingValue))
                {
                    if (firstDateRadioButton.Checked)
                    {
                        MarketAverage firstAverage = marketAverageList.Find(s => s.ClosingValue >= closingValue);
                        searchResultList.Add(firstAverage);
                    }
                    else
                    {
                        searchResultList = marketAverageList.FindAll(s => s.ClosingValue >= closingValue);
                    }

                    var bindingSource = new BindingSource(searchResultList, null);
                    djiaDataGridView.DataSource = bindingSource;
                }
                else
                {
                    MessageBox.Show("A numeric closing value must be entered.");
                }
            }
            else
            {
                MessageBox.Show("A closing value must be entered.");
            }
        }

        /// <summary>
        /// Show the complete list by rebinding the marketAverageList to the DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            source = new BindingSource(marketAverageList, null);
            djiaDataGridView.DataSource = source;
        }

        /// <summary>
        /// Sort the List using a lambda expression and rebind to the DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void djiaDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the List from the Binding Sort.  We need to cast it when retrieving the list
            var resultsList = (List<MarketAverage>)source.List;

            /*
                * If the list is unsorted, the sortAscending value will be null.  If this is the case, we want to
                * set the sortAscending value to false, so the initial sort will be done in Ascending order.
                */
            sortAscending ??= false;

            // Define an instance of the SortOrder enumeration to set the SortGlyphDirection property 
            SortOrder sortOrder;


            if (sortAscending == false)         // List is either unsorted or in descending order
            {
                // Set the enumeration to Ascending
                sortOrder = SortOrder.Ascending;

                // Sort the List on the ClosingValue using the CompareTo function to sort in Ascending Order
                resultsList.Sort((e1, e2) => e1.ClosingValue.CompareTo(e2.ClosingValue));
                sortAscending = true;
            }
            else
            {
                // Set the enumeration to Descending
                sortOrder = SortOrder.Descending;

                // Sort the List on the ClosingValue using the inverse of the CompareTo function to sort in Descending Order
                resultsList.Sort((e1, e2) => (-1 * e1.ClosingValue.CompareTo(e2.ClosingValue)));
                sortAscending = false;
            }

            // Add the sorted list to the BindingSource
            source = new BindingSource(resultsList, null);

            // Update the DataGridView's datasource
            djiaDataGridView.DataSource = source;

            // Only after the DataGridView's datasource is set, do we want to set the column's header SortGlyphDirection property
            djiaDataGridView.Columns[1].HeaderCell.SortGlyphDirection = sortOrder;
        }
    }
}