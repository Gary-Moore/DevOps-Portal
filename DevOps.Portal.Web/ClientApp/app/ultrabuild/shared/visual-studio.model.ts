export interface IVisualStudio {
    solutionName: string;
    projectName: string;
}

export class VisualStudio implements IVisualStudio {
    solutionName: string;
    projectName: string;

    constructor() {
    }
}
