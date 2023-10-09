namespace itchallenges.Pages
{
    public partial class Foto
    {
        private string[] arrImages = { "breakfast.jpg", "flower.jpg", "flower_red.jpg", "fontain.jpg", "lunch.jpg", "sunset.jpg" };
        private string imageUrl = "img/";
        private string log = "";
        private int currentNumber = 0;

        private void ChangeImage()
        {
            int randomnumber;
            log = "Geklikt op nieuwe random (Vorige waarde = " + currentNumber + ") <br>";

            do
            {
                randomnumber = new Random().Next(arrImages.Length);
                log += randomnumber + "<br>";
            } while (randomnumber == currentNumber);

            currentNumber = randomnumber;
            imageUrl = "img/" + arrImages[currentNumber];
        }
    }
}