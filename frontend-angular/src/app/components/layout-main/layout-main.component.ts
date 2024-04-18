import { NestedTreeControl } from '@angular/cdk/tree';
import { Component } from '@angular/core';
import { MatTreeNestedDataSource } from '@angular/material/tree';
import { Router } from '@angular/router';

interface Node {
  name: string;
  icon?: string;
  url?: string;
  children?: Node[];
}

@Component({
  selector: 'app-layout-main',
  templateUrl: './layout-main.component.html',
  styleUrl: './layout-main.component.css'
})
export class LayoutMainComponent {

  treeControl = new NestedTreeControl<Node>(node => node.children);
  dataSource = new MatTreeNestedDataSource<Node>();
  isSidebarOn: boolean = true;
  activeNode: unknown;

  constructor(public router: Router) {
    this.dataSource.data = this.setupTreenode();
  }

  setupTreenode(): Node[] {
    const treeNodes: Node[] = [
      {
        name: 'Products',
        icon: 'storefront',
        url: './products',
      },
    ];

    return treeNodes;
  }

  toggleSidebar() {
    this.isSidebarOn = !this.isSidebarOn;
  }

  setActiveNode(node: Node) {
    this.activeNode = node;
  }
}
