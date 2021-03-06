﻿import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'item',
    templateUrl: './item.component.html'
})
export class ItemComponent {
    public items: itemModel[];
    weight = 0;

    constructor(http: Http, @Inject('ORIGIN_URL') originUrl: string) {
        http.get(originUrl + '/api/Items/GetList').subscribe(result => {
            this.items = result.json() as itemModel[];
        });
    }
}

interface itemModel{
    itemId: number;
    name: string;
    description: string;
    weight: string;
}
