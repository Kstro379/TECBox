import { TestBed } from '@angular/core/testing';

import { DataListaRepartoService } from './data-lista-reparto.service';

describe('DataListaRepartoService', () => {
  let service: DataListaRepartoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DataListaRepartoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
