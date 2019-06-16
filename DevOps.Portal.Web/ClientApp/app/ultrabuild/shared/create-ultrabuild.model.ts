import { IUltraBuild } from './ultrabuild.model';
import { IVisualStudio, VisualStudio } from './visual-studio.model';
import { IOctopus, Octopus } from './octopus.model';
import { IGitLab, GitLab } from './gitlab.model';

export class UltraBuild implements IUltraBuild {
    gitLab: IGitLab = new GitLab();
    visualStudio: IVisualStudio = new VisualStudio();
    octopus: IOctopus = new Octopus();

    constructor() {
    }
}
