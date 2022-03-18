<template>
<div class="tag">
  {{props.tag}}
</div>
</template>

<script>
export default {
  name: "Tag"
}
</script>

<script setup>
import {defineProps} from "vue"
const props = defineProps(["tag"])
</script>

<style scoped>
.tag {
    color: var(--powder700);
    border: 1px solid var(--powder500);
    background-color: var(--powder100);
    padding: 2px 5px;
    display: block;
    width: fit-content;
    border-radius: 3px;
    font-size: 13px;
    white-space: nowrap
}
</style>