namespace DevOps.Portal.Application.Teamcity.Commands.CreateProject.Factory
{
    public class CreateTeamcityProjectFactory : ICreateTeamcityProjectFactory
    {
        public CreateTeamcityProjectModel Create(string name, string parentName = null)
        {
            var model = new CreateTeamcityProjectModel()
            {
                Name = name
            };

            if (string.IsNullOrEmpty(parentName))
            {
                model.ParentProject = new ParentProjectModel()
                {
                    Locator = "id:_Root"
                };

                //model.Id = $"{name}";
            }
            else
            {
                model.ParentProject = new ParentProjectModel()
                {
                    Locator = $"id:{parentName}"
                };

               // model.Id = $"{parentName}_{name}";
            }
            

            return model;
        }
    }
}
