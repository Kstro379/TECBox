import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeAdministracionComponent } from './home-administracion.component';

describe('HomeAdministracionComponent', () => {
  let component: HomeAdministracionComponent;
  let fixture: ComponentFixture<HomeAdministracionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HomeAdministracionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HomeAdministracionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
