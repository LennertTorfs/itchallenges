namespace itchallenges.Pages
{
    public partial class FunFacts
    {
        private string result = "";

        private void CalculateFunFacts()
        {
            DateTime geboortedatum = DateTime.Now; // Replace with the actual birthdate from user input or storage
            DateTime nu = DateTime.Now;

            string gbdag = geboortedatum.ToString("dddd, dd MMMM yyyy");

            result = "Je bent geboren op " + gbdag + "<br>";

            result += "Vandaag is het " + nu.ToString("dddd, dd MMMM yyyy") + "<br>";

            double diffInDays = (nu - geboortedatum).TotalDays;
            result += "Je loopt al " + Math.Round(diffInDays) + " dagen op deze wereldbol rond. <br>";

            const double gemJaren = 80.3;
            double totDagen = 365 * gemJaren;
            double nogTeLevenDagen = Math.Round(totDagen - diffInDays);
            DateTime teLeven = nu.AddDays(nogTeLevenDagen);

            result += "Je zal vermoedelijk sterven op " + teLeven.ToString("dddd, dd MMMM yyyy") + "<br>";
        }
    }
}
