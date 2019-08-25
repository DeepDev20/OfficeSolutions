import { Component, OnInit } from '@angular/core';
import { NgbCarousel } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-slider',
  templateUrl: './slider.component.html',
  styleUrls: ['./slider.component.scss'],
  providers:[NgbCarousel]
})
export class SliderComponent implements OnInit {

  constructor(NgbCarouselConfig:NgbCarousel) { 

    NgbCarouselConfig.interval = 200;
    NgbCarouselConfig.wrap = true;
    NgbCarouselConfig.keyboard = false;
    NgbCarouselConfig.pauseOnHover = true;
  
  }

  ngOnInit() {
    
  }

}
