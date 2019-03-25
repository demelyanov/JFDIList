import { IDeserializable } from '../IDeserializable';

export interface ITaskModel {
    id: number;
    task: string;
    taskDate?: Date;
    createdDate: Date;
    done: boolean;
    important: boolean;
    urgently: boolean;
}

export class TaskModel implements ITaskModel, IDeserializable<TaskModel> {
    id: number;
    task: string;
    taskDate?: Date;
    createdDate: Date;
    done: boolean;
    important: boolean;
    urgently: boolean;

    constructor() {
        this.id = 0;
        this.task = null;
        this.taskDate = null;
        this.createdDate = new Date();
    }

    deserialize(input: any): TaskModel {
        Object.assign(this, input);
        return this;
    }

}