import { Component } from '@angular/core';
import { IPessoa } from './pessoa';
import { OnInit } from '@angular/core/src/metadata/lifecycle_hooks';
import { PessoasService } from './pessoa.services';

@Component({
    selector: 'pessoas',
    templateUrl: './pessoas.component.html'
})
export class PessoasComponent implements OnInit {
    constructor(private pessoaService: PessoasService) {

    }
    pessoas: any;

    ngOnInit(): void {
        this.pessoaService.getPessoas().subscribe(
            ((pes) => {
                //console.log(pes);
                //console.log(pes.json());
                this.pessoas = pes.json();
            })
        );
    }



}
