namespace microservice.models
{
    public class product
    {
     private int id = 0;
        private string name="";
        private int prix=0;
        private int prixachat=0;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Prix { get => prix; set => prix = value; }
        public int Prixachat { get => prixachat; set => prixachat = value; }

        public override string ToString()
        {
            return $"my Id is : {Id}, call me {Name} and I cost {Prix}";
        }
    }   
}
