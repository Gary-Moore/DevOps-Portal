import { IVisualStudio } from './visual-studio.model';
import { IOctopus } from './octopus.model';
import { IGitLab } from './gitlab.model';

export interface IUltraBuild {
    visualStudio: IVisualStudio;
    octopus: IOctopus;
    gitLab: IGitLab;
}

