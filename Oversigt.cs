using System;

internal class Oversigt
{
	public Oversigt()
	{
		
		List<Model> modeller = new List<Model>();

        public void CreateModel()
	{
        Model usecase = new Model();
        usecase.id = 1;
        usecase.navn = "Use Case";
        usecase.beskrivelse = "Denne usecase er god";
        modeller.Add(usecase);

        Model klassediagram = new Model();
        klassediagram.id = 2;
        klassediagram.navn = "Klassediagram";
        klassediagram.beskrivelse = "God dag";
        modeller.Add(klassediagram);

        Model sekvensdiagram = new Model("Sekvensdiagram", "Et eller andet", 3);
        modeller.Add(sekvensdiagram);
    }

}
}
