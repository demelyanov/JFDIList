import { TaskModel } from './../../models/tasks/Task.model';
import { TasksService } from './../../services/tasks/Tasks.service';
import { OnInit, Component } from '@angular/core';

@Component({
    selector: "importance-urgency-list",
    templateUrl: "./imp.urgency.list.component.html",
    styleUrls: ["./imp.urgency.list.component.scss"]
}) 
export class ImportanceUrgencyListComponent implements OnInit {
    
    private _tasks: TaskModel[] = [];

    constructor(private _tasksService: TasksService) {}

    ngOnInit(): void {
        this._tasksService.getList().subscribe( res => {
            this._tasks = res;
        });
    }

    onTaskChange(task: TaskModel): void {
        task.done = !task.done;
        console.log('Yahooo');
        this._tasksService.setState(task.id, !task.done).subscribe(res=> {
            
        }); 
    }

    /* properties */

    get Tasks(): TaskModel[] {
        return this._tasks;
    }
}