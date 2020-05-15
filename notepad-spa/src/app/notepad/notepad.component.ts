import { Component, OnInit, HostListener } from '@angular/core';

@Component({
  selector: 'app-notepad',
  templateUrl: './notepad.component.html',
  styleUrls: ['./notepad.component.css']
})
export class NotepadComponent implements OnInit {

  savedContent: string;
  isSaved: boolean;

  constructor() { }

  ngOnInit(): void {
    this.savedContent = 'some text here';
    this.isSaved = true;
  }

  saveChanges() {
    this.isSaved = true;
  }

  clickToEdit() {
    this.isSaved = false;
  }
}
