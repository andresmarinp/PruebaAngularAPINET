import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AnimalescorralComponent } from './animalescorral.component';

describe('AnimalescorralComponent', () => {
  let component: AnimalescorralComponent;
  let fixture: ComponentFixture<AnimalescorralComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AnimalescorralComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AnimalescorralComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
