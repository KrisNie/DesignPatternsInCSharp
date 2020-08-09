using FactoryMethod.Page;

namespace FactoryMethod.Document
{
    public class Resume: AbstractDocument
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}