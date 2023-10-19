import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListOfTanksComponent } from './list-of-tanks.component';

describe('ListOfTanksComponent', () => {
  let component: ListOfTanksComponent;
  let fixture: ComponentFixture<ListOfTanksComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ListOfTanksComponent]
    });
    fixture = TestBed.createComponent(ListOfTanksComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
