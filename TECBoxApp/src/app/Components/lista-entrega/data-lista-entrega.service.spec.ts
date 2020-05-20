import { TestBed } from '@angular/core/testing';

import { DataListaEntregaService } from './data-lista-entrega.service';

describe('DataListaEntregaService', () => {
  let service: DataListaEntregaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DataListaEntregaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
