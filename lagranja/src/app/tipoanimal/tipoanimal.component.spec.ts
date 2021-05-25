import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TipoanimalComponent } from './tipoanimal.component';

describe('TipoanimalComponent', () => {
  let component: TipoanimalComponent;
  let fixture: ComponentFixture<TipoanimalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TipoanimalComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TipoanimalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
