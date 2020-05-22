import { TestBed } from '@angular/core/testing';

import { DataListaProductosService } from './data-lista-productos.service';

describe('DataListaProductosService', () => {
  let service: DataListaProductosService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DataListaProductosService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
