
export class DataResponse<T> {
    succeeded: boolean = false;
    message: string = "";
    data!: T;
}

export class Response{
    succeeded: boolean = false;
    message: string = "";
}
