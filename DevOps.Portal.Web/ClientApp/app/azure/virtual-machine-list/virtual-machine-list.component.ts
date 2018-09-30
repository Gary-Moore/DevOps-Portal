import { Component, OnInit } from '@angular/core';
import { AzureService } from '../azure.service';
import { VirtualMachine } from '../shared/virtual-machine.model';

@Component({
  selector: 'app-virtual-machine-list',
  templateUrl: './virtual-machine-list.component.html',
  styleUrls: ['./virtual-machine-list.component.scss']
})
export class VirtualMachineListComponent implements OnInit {

  constructor(private azure: AzureService ) {
    this.virtualMachines = azure.virtualMachines;
  }

  public virtualMachines: VirtualMachine[] = [];

  ngOnInit() {
      this.azure.loadVirtualMachines()
          .subscribe(success => {
              if (success) {
                  this.virtualMachines = this.azure.virtualMachines;
              }
          });
  }

}
