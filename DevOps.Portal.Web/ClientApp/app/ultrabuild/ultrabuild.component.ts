import { Component, OnInit } from '@angular/core';
import { IUltraBuild } from './shared/ultrabuild.model';
import { UltraBuild } from './shared/create-ultrabuild.model';
import { UltraBuildService } from './shared/ultrabuild.service';

@Component({
  selector: 'app-ultrabuild',
  templateUrl: './ultrabuild.component.html',
  styleUrls: ['./ultrabuild.component.scss']
})
export class UltrabuildComponent implements OnInit {
  model: IUltraBuild;
  constructor(private ultraBuildService: UltraBuildService) { }

  ngOnInit() {
    this.model = new UltraBuild();
  }

  stepNext(e: any) {
    console.log(e);
  }

  complete(): void {
    this.ultraBuildService.build(this.model).subscribe(success => {
      console.log('completed ' + success);
    });
  }
}
