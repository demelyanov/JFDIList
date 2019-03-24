import { TasksService } from './../../../services/tasks/Tasks.service';
import { TaskModel } from 'src/app/models/tasks/Task.model';

import { OnInit, Component } from '@angular/core';

@Component({
    selector: "main-header",
    templateUrl: "./main.header.html",
    styleUrls: ["./main.header.scss"] 
})
export class MainHeaderNavComponent implements OnInit {

    private _task: TaskModel = new TaskModel();

    constructor(private _tasksService: TasksService) {}

    ngOnInit(): void {
    }

    onAddClick(): void {
        this._tasksService.saveTask(this._task).subscribe( res => {
            this._task = res;
        });
    }

    /* properties */

    get Task(): TaskModel{
        return this._task;
    }
}