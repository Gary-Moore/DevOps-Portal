import { IUltraBuild } from './ultrabuild.model';
import { IVisualStudio, VisualStudio } from './visual-studio.model';

export class UltraBuild implements IUltraBuild {
    visualStudio: IVisualStudio = new VisualStudio();

    constructor() {
    }
}
