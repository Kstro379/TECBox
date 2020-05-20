import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListaRepartoComponent } from './lista-reparto.component';

describe('ListaRepartoComponent', () => {
  let component: ListaRepartoComponent;
  let fixture: ComponentFixture<ListaRepartoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListaRepartoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListaRepartoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
